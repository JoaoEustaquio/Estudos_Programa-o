using System;

namespace Desafio_Adrian002
{
    class Program
    {
        static void Main(string[] args)
        {

            var decisao = "";


            do
            {
                //Introdução
                Console.WriteLine("Olá, seja bem-vindo a nossa aplicação. Pressione ENTER para iniciar.");
                Console.ReadLine();
                Console.Clear();


                Console.WriteLine("O que você gostaria de fazer?");
                Console.WriteLine("1) Adicionar Regiões");
                Console.WriteLine("2) Visualizar Regiões");
                Console.WriteLine("3) Adicionar Unidades");
                Console.WriteLine("4) Visualizar Unidades");
                Console.Write("\r\nSelect an option: ");
                

                decisao = Console.ReadLine();
                Console.Clear();
                switch (decisao.ToUpper())
                {
                    case "1":
                        Console.WriteLine("Qual o nome da regiao?");
                        var nomeRegiao = Console.ReadLine();
                        Console.WriteLine("Qual a descricao da região?");
                        var descricaoRegiao = Console.ReadLine();
                        ClientAPI.AdicionarRegiao(nomeRegiao, descricaoRegiao);
                        Console.ReadKey();
                    break;

                    case "2":
                        ClientAPI.ShowRegiao(nomeRegiao, descricaoRegiao);
                        Console.ReadKey();
                    break;

                    case "3":
                        Console.WriteLine("Qual o nome da regiao da unidade?");
                        var nomeregiao = Console.ReadLine();
                        Console.WriteLine("Qual o código da unidade?");
                        var codigo = Console.ReadLine();
                        Console.WriteLine("Qual o CNPJ da unidade?");
                        var cnpj = Console.ReadLine();
                        Console.WriteLine("Qual o nome da unidade?");
                        var nome = Console.ReadLine();
                        Console.WriteLine("Qual o status atual da unidade?");
                        var status = Console.ReadLine();
                        ClientAPI.AdicionarUnidade(nomeregiao, codigo, cnpj, nome, status);
                        Console.ReadKey();
                    break;

                    case "4":

                    break;
                }
            } while (false); //-> fazer teste logico aqui
        }
    }
}
