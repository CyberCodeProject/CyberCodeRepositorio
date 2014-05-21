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
            
                Console.Write("* Login : "); 
                login = Console.ReadLine();
            
            //Apenas a verificacao de teste do login
            
            while(!login.ToLower().Equals("luis")){
                Console.WriteLine("Login incorreto! Informe novamente.");
                Console.Write("* Login : ");
                login = Console.ReadLine();
            }

            
            Console.Write("* Senha : "); 
            senha = int.Parse(Console.ReadLine());

            //Apenas a verificacao de teste da senha

            while (senha != 123)
            {
                Console.WriteLine("Senha incorreta!Informe novamente.");
                Console.Write("* Senha : ");
                senha = int.Parse(Console.ReadLine());
            }
            
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
