using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luis
{
    class Program
    {
        static void Main(string[] args)
        {

            string login;
            int senha;

            Console.WriteLine("**************************************************************");
            Console.WriteLine("*                    Bem-vindo ao sistema!                   *");
            Console.WriteLine("*                  Informe seu login e senha                 *");
            Console.WriteLine("**************************************************************");
            do
            {
                Console.Write("* Login : "); 
                login = Console.ReadLine();
            }while(!login.ToLower().Equals("luis"));
            do
            {
                Console.Write("* Senha : "); senha = int.Parse(Console.ReadLine());
            }while (senha != 123);
            
            Console.WriteLine("\a**************************************************************");

            Console.Clear();

            //Chamando o método MENU
            Menu();

            Console.ReadKey();
        }


        public static void Menu()
        {

            Console.WriteLine("**************************************************************");
            Console.WriteLine("*              LOCACAO DE VEICULOS - CYBER CAR               *");     
            Console.WriteLine("**************************************************************");
            Console.WriteLine("*                            MENU                            *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("*                        1 - Cadastro                        *");
            Console.WriteLine("*                        2 - Consulta                        *");
            Console.WriteLine("*                        3 - Movimento                       *");
            Console.WriteLine("*                        4 - Alteracao                       *");
            Console.WriteLine("*                        5 - Relatorio                       *");
            Console.WriteLine("*                        6 - Ajuda                           *");
            Console.WriteLine("*                        7 - Sair                            *");
            Console.WriteLine("**************************************************************");


            char opcao = char.Parse(Console.ReadLine());

            

                switch (opcao)
                {
                    case '1': Console.WriteLine("SISTEMA TEMPORAROAMENTE FORA DO AR!");
                        break;
                    case '2': Console.WriteLine("SISTEMA TEMPORAROAMENTE FORA DO AR!");
                        break;
                    case '3': Console.WriteLine("SISTEMA TEMPORAROAMENTE FORA DO AR!");
                        break;
                    case '4': Console.WriteLine("SISTEMA TEMPORAROAMENTE FORA DO AR!");
                        break;
                    case '5': Console.WriteLine("SISTEMA TEMPORAROAMENTE FORA DO AR!");
                        break;
                    case '6': Console.WriteLine("SISTEMA TEMPORAROAMENTE FORA DO AR!");
                        break;
                    case '7': Console.WriteLine("SISTEMA TEMPORAROAMENTE FORA DO AR!");
                        break;
                    default: Console.WriteLine("OPA! NÃO SE IRRITE. SISTEMA TEMPORAROAMENTE FORA DO AR!");
                    break;
                }

            
        }

      
    
    }
}
