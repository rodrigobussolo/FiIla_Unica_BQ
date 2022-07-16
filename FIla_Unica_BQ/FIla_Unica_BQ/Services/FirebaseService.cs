using Fila_Unica_BQ.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fila_Unica_BQ.Services
{
    public class FirebaseService
    {
        readonly FirebaseClient firebase = new FirebaseClient("https://fila-unica-brusque-default-rtdb.firebaseio.com/");

        readonly string codURL = Models.OrigemInscricao.Origem;

        public async Task AddCandidato(int posicao, int protocoloid, string data_dora, string opcao1, string opcao2, string opcao3)
        {
            await firebase.Child("Candidatos" + codURL).PostAsync(new Candidato()
            {
                Posicao = posicao,
                ProtocoloId = protocoloid,
                Data_Hora = data_dora,
                Opcao1 = opcao1,
                Opcao2 = opcao2,
                Opcao3 = opcao3
            });
        }

        public async Task<List<Candidato>> GetCandidatos()
        {
            return (await firebase.Child("Candidatos" + codURL).OnceAsync<Candidato>()).Select(item => new Candidato
            {
                Posicao = item.Object.Posicao,
                ProtocoloId = item.Object.ProtocoloId,
                Data_Hora = item.Object.Data_Hora,
                Opcao1 = item.Object.Opcao1,
                Opcao2 = item.Object.Opcao2,
                Opcao3 = item.Object.Opcao3
            }).ToList();
        }

        public async Task<Candidato> GetCandidato(int ProtocoloId)
        {
            var candidatos = await GetCandidatos();
            await firebase.Child("Candidatos" + codURL).OnceAsync<Candidato>();
            return candidatos.Where(a => a.ProtocoloId == ProtocoloId).FirstOrDefault();
        }

        public async Task AddEscola(int CodEscola, string NomeEscola, string EnderecoEscola, string FoneEscola, int opcao1, int opcao2, int opcao3)
        {
            await firebase.Child("Escolas").PostAsync(new Escola()
            {
                EscolaCod = CodEscola,
                EscolaNome = NomeEscola,
                EscEndereco = EnderecoEscola,
                EscFone = FoneEscola,
                Opcao1 = opcao1,
                Opcao2 = opcao2,
                Opcao3 = opcao3,
                Opcoes = "1ª Opção: " + opcao1 + "  |  2ª Opção: " + opcao2 + "  |  3ª Opção: " + opcao3
            });
        }

        public async Task<List<Escola>> GetEscolas()
        {
            return (await firebase.Child("Escolas").OnceAsync<Escola>()).Select(item => new Escola
            {
                EscolaCod = item.Object.EscolaCod,
                EscolaNome = item.Object.EscolaNome,
                EscEndereco = item.Object.EscEndereco,
                EscFone = item.Object.EscFone,
                Opcao1 = item.Object.Opcao1,
                Opcao2 = item.Object.Opcao2,
                Opcao3 = item.Object.Opcao3,
                Opcoes = item.Object.Opcoes
            }).ToList();
        }

        public async Task<Escola> GetEscola(int codigo)
        {
            var escolas = await GetEscolas();
            await firebase.Child("Escolas").OnceAsync<Escola>();
            return escolas.Where(a => a.EscolaCod == codigo).FirstOrDefault();
        }

        public async Task Atualiza_Data()
        {
            await firebase.Child("DataAtualizacao" + codURL).DeleteAsync();
            await firebase.Child("DataAtualizacao" + codURL).PostAsync(new Atualizacao() { Ultima_atualizacao = DateTime.Now.Date });
        }

        public async Task DeletaTudo()
        {
            await firebase.Child("Candidatos" + codURL).DeleteAsync();
        }

        public async Task DeletaEscolas()
        {
            await firebase.Child("Escolas").DeleteAsync();
        }
    }
}
