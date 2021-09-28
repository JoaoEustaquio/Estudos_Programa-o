using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Adrian002
{
    public class ClientAPI
    {
        //Regioes
        public static bool AdicionarRegiao(string nome, string descricao)
        {
            //tem que ser revisada -> ela precisar retornar false se o status for diferente de 200;
            var client = new RestClient("http://localhost:5000/api/Regiao?Nome="+ nome + "&Descricao=" + descricao);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "true");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return true;
        }
       
        public static bool ShowRegiao(string nome, string descricao)
        {
            var client = new RestClient("http://localhost:5000/api/Regiao");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "true");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            return true;
        }

        public static List<Regiao> GetRegiaos()
        {
            var r = new List<Regiao>();
            return r;
        }

        //Unidades
        public static bool AdicionarUnidade(string nomeregiao, string codigo, string cnpj, string nome, string status)
        {
            var client = new RestClient("http://localhost:5000/api/Unidade?NomeRegiao="+ nomeregiao + "&Codigo=" + codigo +"&Cnpj=" + cnpj + "&Nome=" + nome + "&Status=" + status);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "true");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            
            return true;
        }

        public static List<Unidade> GetUnidades()
        {
            var u = new List<Unidade>();
            return u;
        }
        //lista região -> retornar um objeto -> utilizar a classe regiao como objeto
        //adicionar Unidade -> retornar se foi true ou false
        //listar unidade -> retornar um objeto -> utilizar a classe regiao como objeto
    }
}
