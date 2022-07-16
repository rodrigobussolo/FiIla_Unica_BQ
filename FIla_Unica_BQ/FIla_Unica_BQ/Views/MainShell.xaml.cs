using Fila_Unica_BQ.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fila_Unica_BQ.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainShell : ContentPage
    {
        public MainShell()
        {
            InitializeComponent();

            Models.Dados_gerais.Titulo = "SOBRE";
            Models.Dados_gerais.SubTitulo = "Informativo";
            Models.Dados_gerais.Texto = AppResources.Sobre;
            Models.Dados_gerais.Origem = 0;

        }

        //private async void Btn2_Clicked()
        //{
        //    await Navigation.PushAsync(new Pagina());
        //}
    }
}