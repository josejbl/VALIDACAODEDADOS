using System;

namespace VALIDACAO_DE_DADOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de Dados");

            Console.WriteLine("Digite o nome do usuario");
            string nome = Console.ReadLine();

            while(nome == ""){

                Console.WriteLine("O nome não popde ser vazio");
                Console.WriteLine("Digite o nome de usuario");
                nome = Console.ReadLine();


            }


        }
    }
}
