using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fila_Unica_BQ.Services;
using Firebase.Database;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Xamarin.Android.Net;
using HtmlAgilityPack;
using Org.Json;
using Fila_Unica_BQ.Resources;

namespace Fila_Unica_BQ.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina : ContentPage
    {
        private readonly string url = "https://filaunica.brusque.sc.gov.br/dmd/pub/qfilapub.php";
        readonly FirebaseService fbService = new FirebaseService();
        readonly FirebaseClient firebase = new FirebaseClient("https://fila-unica-brusque-default-rtdb.firebaseio.com/");

        //private static readonly List<string> list = new List<string>();
        //readonly List<string> listaString = list;

        string codigo = "";
        string descricao = "";
        int opc_1 = 0;
        int opc_2 = 0;
        int opc_3 = 0;

        public Pagina()
        {
            InitializeComponent();

            Pagina_Conteudo.Title = AppResources.AppName;

            lbl_Titulo.Text = Models.Dados_gerais.Titulo;
            lbl_SubTitulo.Text = Models.Dados_gerais.SubTitulo;

            if (Models.Dados_gerais.Origem == 1)
            {
                Models.OrigemInscricao.Origem = "Escola";

                scr_Texto.IsVisible = false;
                lbl_Texto.IsVisible = false;

                Atualiza_Escola();
                Listar();
            }
            else
            {
                Layout_Lista.IsVisible = false;
                listaEscola.IsVisible = false;

                lbl_Texto.Text = Models.Dados_gerais.Texto;

                AIndicator.IsRunning = false;
            }
        }

        private async void Atualiza_Escola()
        {
            try
            {
                DateTime DataAtualizacao = Convert.ToDateTime("01/01/0001");
                DateTime Data_aux = DateTime.Now.Date;

                var Data = (await firebase.Child("DataAtualizacaoEscola")
                   .OnceAsync<Models.Atualizacao>()).Select(item => new Models.Atualizacao
                   {
                       Ultima_atualizacao = item.Object.Ultima_atualizacao,
                   });

                if (Data != null)
                {
                    foreach (var item in Data)
                    {
                        DataAtualizacao = item.Ultima_atualizacao;
                    }
                }

                if (Data_aux > DataAtualizacao)
                {
                    var httpClient = new HttpClient();

                    HttpResponseMessage response = await httpClient.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        await fbService.DeletaEscolas();
                        var s = await response.Content.ReadAsStringAsync();

                        var htmlDoc = new HtmlDocument();
                        htmlDoc.LoadHtml(s);

                        var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//table/tbody/tr/td");

                        int position = 0;
                        int linha = 1;
                        foreach (var node in htmlNodes)
                        {
                            if (linha == 1)
                            {
                                position = node.InnerText.IndexOf("-");
                                codigo = node.InnerText.Substring(0, 3);
                                descricao = node.InnerText.Substring(position + 1).Trim();
                            }
                            else
                            {
                                if (linha == 2)
                                {
                                    if (node.InnerText.Length > 0) { opc_1 = Int32.Parse(node.InnerText); }
                                }

                                if (linha == 3)
                                {
                                    if (node.InnerText.Length > 0) { opc_2 = Int32.Parse(node.InnerText); }
                                }

                                if (linha == 4)
                                {
                                    if (node.InnerText.Length > 0) { opc_3 = Int32.Parse(node.InnerText); }

                                    await fbService.AddEscola(Int32.Parse(codigo), descricao, "","", opc_1, opc_2, opc_3);

                                    opc_1 = 0;
                                    opc_2 = 0;
                                    opc_3 = 0;
                                    linha = 0;
                                }
                            }

                            linha++;
                        }
                        await fbService.Atualiza_Data();
                    }
                }
            }
            catch { }
        }

        public async void Listar() { await ListaEscolas(); }

        private async Task ListaEscolas()
        {
            try
            {
                var escolas = await fbService.GetEscolas();
                listaEscola.ItemsSource = escolas;

                AIndicator.IsRunning = false;
            }
            catch { }
        }
    }
}