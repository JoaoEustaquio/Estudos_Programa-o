using System;

namespace Desafio_002
{
    class Program
    {
        static void Main(string[] args)
        {

            string mensagem;
            string nome;
            string sobrenome;
            int idade;
            string sexo;

            //Nome
            Console.WriteLine(mensagem = "Olá Visitante, vamos fazer seu cadastro no nosso site? Primeiro informe seu nome.");
            nome = Console.ReadLine();
            Console.WriteLine(mensagem = "Certo, agora informe seu sobrenome.");
            sobrenome = Console.ReadLine();

            Console.Clear();


            //Idade
            Console.WriteLine("Certo, " + nome + " " + sobrenome + " agora precisamos saber a sua idade.");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (idade < 25)
            {
                Console.WriteLine("Então você tem " + idade + " anos, agora precisamos saber o seu sexo. Presione ENTER para continar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Então você tem " + idade + " anos, ta velho ein. Agora precisamos saber o seu sexo. Presione ENTER para continar.");
                Console.ReadLine();
            }

            //SEXO

            Console.Clear();
            Console.WriteLine("Você se identifica como, MASCULINO, FEMININO OU OUTRO?");
            sexo = Console.ReadLine();

            if (sexo.ToLower() == "Feminino" || sexo.ToLower() == "FEMININO")
            {
                Console.WriteLine("Então você se idenfica sendo do sexo FEMININO, precisone ENTER, para ter a visão geral da sua ficha.");
                Console.ReadLine();
            }
            else if (sexo.ToLower() == "Masculino" || sexo.ToLower() == "MASCULINO")
            {
                Console.WriteLine("Então você se idenfica sendo do sexo MASCULINO, precisone ENTER, para ter a visão geral da sua ficha.");
                Console.ReadLine();
            }
            else if (sexo.ToLower() == "Outro" || sexo.ToLower() == "OUTRO")
            {
                Console.WriteLine("Então você se idenfica sendo como OUTRO, precisone ENTER, para ter a visão geral da sua ficha.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Você declarou um valor inválido. Mais tarde você poderá editar a sua ficha, pressione ENTER para ter a visão geral da sua ficha.");
                Console.ReadLine();
            }

            //Console.ReadLine();


            //Ficha geral
            Console.Clear();
            Console.WriteLine("Tudo pronto " + nome + ", aqui está sua ficha de cadastro");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Sobrenome: " + sobrenome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Sexo: " + sexo);

            Console.ReadLine();
        }
    }
}
