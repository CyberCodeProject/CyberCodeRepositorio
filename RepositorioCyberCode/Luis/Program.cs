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

            

            //Chamando o método MENU
            Menu();

            Console.ReadKey();
        }

        
        static void Menu()
        {
            Console.Clear();
            //Console.BackgroundColor = ConsoleColor.;
            Console.WriteLine();
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░ LOCACAO DE VEICULOS - CYBER CAR ░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                  MENU                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("║                             1 - CADASTRO                               ║");
            Console.WriteLine("║                             2 - CONSULTA                               ║");
            Console.WriteLine("║                             3 - MOVIMENTO                              ║");
            Console.WriteLine("║                             4 - ALETRACAO                              ║");
            Console.WriteLine("║                             5 - REMOCAO                                ║");
            Console.WriteLine("║                             6 - RELATORIO                              ║");
            Console.WriteLine("║                             7 - AJUDA                                  ║");
            Console.WriteLine("║                             8 - SAIR                                   ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");


            char opcao = char.Parse(Console.ReadLine());

            

                switch (opcao)
                {
                    case '1': MenuCadastro(); 
                        
                        break;
                    case '2': MenuConsulta();
                        
                        break;
                    case '3': MenuMovimento(); 
                        
                        break;
                    case '4': MenuAlteracao();
                        
                        break;
                    case '5': MenuRemocao();
                        
                        break;
                    case '6': MenuRelatorio();
                        
                        break;
                    case '7': MenuAjuda();
                        break;
                    case '8': Console.Clear();
                        break;
                    default: Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                        
                        break;
                }

            
           

        }

         static void MenuCadastro()
        {
            Console.Clear();

            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                              MENU CADASTRO                             ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("║                         1 - CADASTRO VEICULO                           ║");
            Console.WriteLine("║                         2 - CADASTRO CLIENTE                           ║");
            Console.WriteLine("║                         3 - Voltar                                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

            char opcao = char.Parse(Console.ReadLine());
            switch (opcao)
            {


                case '1':  
                          //Chama o  metodo cadastro carro
                          //CadastroCarro();
                          break;
                case '2': 
                          //Chamar metodo cadastro cliente
                          //CadastroCliente();
                          break;
                case '3': Console.Clear(); 
                    Menu();
                    break;
                default: Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                    break;
            }
        }

         static void MenuConsulta()
         {
             Console.Clear();

             Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
             Console.WriteLine("║                              MENU CONSULTA                             ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
             Console.WriteLine("║                         1 - CONSULTAR VEICULO                          ║");
             Console.WriteLine("║                         2 - CONSULTAR CLIENTE                          ║");
             Console.WriteLine("║                         3 - SITUACAO DO VEICULO                        ║");
             Console.WriteLine("║                         4 - Voltar                                     ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

            
             char opcao = char.Parse(Console.ReadLine());
             
             switch (opcao)
             {

                 case '1': 
                     //Chama o  metodo CONSULTA carro
                     //ConsultaCarro();
                     break;
                 case '2':                      
                     //Chamar metodo CONSULTA cliente
                     //ConsultaCliente();
                     break;
                 case '3': Console.Clear();
                     Menu();
                     break;
                 default: Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                     break;
             }
         }

         static void MenuMovimento()
         {
             Console.Clear();

             Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
             Console.WriteLine("║                             MENU MOVIMENTO                             ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
             Console.WriteLine("║                              1 - RESERVA                               ║");
             Console.WriteLine("║                              2 - LOCACAO                               ║");
             Console.WriteLine("║                              3 - DEVOLUCAO                             ║");
             Console.WriteLine("║                              4 - Voltar                                ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

             char opcao = char.Parse(Console.ReadLine());

             switch (opcao)
             {

                 case '1':
                     //Chama o  metodo RESERVA carro
                     //ReservaaCarro();
                     break;
                 case '2':
                     //Chamar metodo LOCACAO carro
                     //Locacao();
                     break;
                 case '3': 
                     //Chamar o metodo DEVOLUCAO carro
                     break;
                 case '4': Console.Clear();
                     Menu();
                     break;
                 default: Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                     break;
             }
             
         }

         static void MenuAlteracao()
         {
             Console.Clear();

             Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
             Console.WriteLine("║                             MENU ALTERACAO                             ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
             Console.WriteLine("║                          1 - ALTERAR VEICULO                           ║");
             Console.WriteLine("║                          2 - ALTERAR CLIENTE                           ║");
             Console.WriteLine("║                          3 - Voltar                                    ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");


             char opcao = char.Parse(Console.ReadLine());

             switch (opcao)
             {

                 case '1':  
                     //Chama o  metodo ALTERACAO carro

                     break;
                 case '2':  
                    //Chamar metodo ALTERACAO cliente

                     break;
                 case '3': Console.Clear();
                     Menu();
                     break;
                 default: Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                     break;
             }
         }

         static void MenuRemocao()
         {
             Console.Clear();

             Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
             Console.WriteLine("║                              MENU REMOCAO                              ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
             Console.WriteLine("║                          1 - REMOCAO VEICULO                           ║");
             Console.WriteLine("║                          2 - REMOCAO CLIENTE                           ║");
             Console.WriteLine("║                          3 - Voltar                                    ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");


             char opcao = char.Parse(Console.ReadLine());

             switch (opcao)
             {

                 case '1': 
                     //Chama o  metodo REMOCAO carro

                     break;
                 case '2':                     //Chamar metodo REMOCAO cliente

                     break;
                 case '3': Console.Clear();
                     Menu();
                     break;
                 default: Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                     break;
             }
         }

         static void MenuAjuda()
         {
             Console.Clear();
             Console.WriteLine("**************************************************************");
             Console.WriteLine("*                        - AJUDA -                           *");
             Console.WriteLine("**************************************************************");
             //Chama o metodo AJUDA
            
         }

         static void MenuRelatorio()
         {
             Console.Clear();

             Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
             Console.WriteLine("║                             MENU RELATORIO                             ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
             Console.WriteLine("║                        1 - RELATORIO DO VEICULO                        ║");
             Console.WriteLine("║                        2 - RELATORIO DO CLIENTE                        ║");
             Console.WriteLine("║                        3 - RELATORIO DA RENSA MENSAL                   ║");
             Console.WriteLine("║                        4 - RELATORIO DO CAIXA                          ║"); 
             Console.WriteLine("║                        5 - Voltar                                      ║");
             Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");


             

             char opcao = char.Parse(Console.ReadLine());

             switch (opcao)
             {

                 case '1': 
                           //Chama o  metodo RELATORIO carro

                     break;
                 case '2': 
                           //Chamar metodo RELATORIO cliente

                     break;
                 case '3': 
                           
                           //Chamar metodo RELATORIO reda mensal
                     break;
                 case '4': 
                          //Chamar metodo RELATORIO do caixa
                     break;
                 case '5': Menu();
                     break;
                 default: Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                     break;
             }
         }

    }
}
