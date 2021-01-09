using System;

namespace VALIDACAO_DE_DADOS
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.WriteLine("Validação de Dados");
               Console.WriteLine("--------------------");

               Console.WriteLine("Digite o nome do usuario");
               string nome = Console.ReadLine();

                while(nome == ""){

                Console.WriteLine("O nome não popde ser vazio");
                Console.WriteLine("Digite o nome de usuario");
                nome = Console.ReadLine();
            }

                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());

            while (idade< 0 || idade > 150)
            {


                Console.WriteLine("A idade deve ser entre 0 e 150");
                Console.WriteLine("Digite sua idade novamente");
                idade = int.Parse(Console.ReadLine());

            }

                Console.WriteLine("Digite o seu salário");
                float salario = float.Parse(Console.ReadLine());

            while(salario <=0)
            {
                Console.WriteLine("O Salário deve ser maior que zero");
                Console.WriteLine("Digite seu salário :");
                salario = float.Parse(Console.ReadLine());
            } 

            bool validacao = true;

            do
            {
                
                Console.WriteLine("Estado Civil - Selcione uma opção abaixo");
                Console.WriteLine("s - Solteiro");
                Console.WriteLine("c - Casado");
                Console.WriteLine("v - viuvo");
                Console.WriteLine("d - Divorciado");

            string opcao = Console.ReadLine();


            switch (opcao.ToLower())
            {

                case "s":
                Console.WriteLine("Você selecionou Solteiro");
                validacao = true;
                    break;
                case "c":
                Console.WriteLine("Você slecionou Casado");
                validacao = true;
                break;
                case "v":
                Console.WriteLine("Você selecionou Viuvo");
                validacao = true;
                break;
                case "d":
                Console.WriteLine("Você selecionou Divorciado");
                validacao = true;
                break;
                default:
                Console.WriteLine("Você de selecinar umas das opção do menu");
                validacao = false;
                    break;
            }
            


            } while (validacao == false);

               Console.WriteLine("Estado Civil cadastrado");








        }
    }
}
