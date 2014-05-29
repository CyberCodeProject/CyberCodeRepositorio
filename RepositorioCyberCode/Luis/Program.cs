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

            Console.Clear();

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
            Console.WriteLine("║                         1 - Cadastrar Veiculo                          ║");
            Console.WriteLine("║                         2 - Cadastrar Cliente                          ║");
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
             Console.WriteLine("║                         1 - Consultar Veiculo                          ║");
             Console.WriteLine("║                         2 - Consultar Cliente                          ║");
             Console.WriteLine("║                         3 - Voltar                                     ║");
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

             Console.WriteLine("**************************************************************");
             Console.WriteLine("*                      - MOVIMENTO -                         *");
             Console.WriteLine("**************************************************************");
             //Chama o metodo MOVIMENTO
         }

         static void MenuAlteracao()
         {
             Console.Clear();

             Console.WriteLine("**************************************************************");
             Console.WriteLine("*                      MENU ALTERACAO                        *");
             Console.WriteLine("**************************************************************");
             Console.WriteLine("*                   1 - Alterar Veiculo                      *");
             Console.WriteLine("*                   2 - Alterar Cliente                      *");
             Console.WriteLine("*                   3 - Voltar                               *");
             Console.WriteLine("**************************************************************");


             char opcao = char.Parse(Console.ReadLine());

             switch (opcao)
             {

                 case '1': Console.WriteLine("**************************************************************");
                           Console.WriteLine("*                    ALTERACAO  -  VEICULO                   *");
                           Console.WriteLine("**************************************************************"); 
                     //Chama o  metodo Alteracao carro

                     break;
                 case '2': Console.WriteLine("**************************************************************");
                           Console.WriteLine("*                    ALTERACAO  -  CLIENTE                   *");
                           Console.WriteLine("**************************************************************");
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

             Console.WriteLine("**************************************************************");
             Console.WriteLine("*                        MENU REMOCAO                        *");
             Console.WriteLine("**************************************************************");
             Console.WriteLine("*                    1 - Remover Veiculo                     *");
             Console.WriteLine("*                    2 - Remover Cliente                     *");
             Console.WriteLine("*                    3 - Voltar                              *");
             Console.WriteLine("**************************************************************");


             char opcao = char.Parse(Console.ReadLine());

             switch (opcao)
             {

                 case '1': Console.WriteLine("**************************************************************");
                           Console.WriteLine("*                     REMOCAO  -  VEICULO                    *");
                           Console.WriteLine("**************************************************************");
                     //Chama o  metodo REMOCAO carro

                     break;
                 case '2': Console.WriteLine("**************************************************************");
                           Console.WriteLine("*                     REMOCAO  -  CLIENTE                    *");
                           Console.WriteLine("**************************************************************");
                     //Chamar metodo REMOCAO cliente

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

             Console.WriteLine("**************************************************************");
             Console.WriteLine("*                      MENU RELATORIO                        *");
             Console.WriteLine("**************************************************************");
             Console.WriteLine("*                 1 - Relatorio do Veiculo                   *");
             Console.WriteLine("*                 2 - Relatorio do Cliente                   *");
             Console.WriteLine("*                 3 - Relatorio da Rensa Mensal              *");
             Console.WriteLine("*                 4 - Relatorio do Caixa                     *");
             Console.WriteLine("**************************************************************");


             char opcao = char.Parse(Console.ReadLine());

             switch (opcao)
             {

                 case '1': Console.WriteLine("**************************************************************");
                           Console.WriteLine("*                    RELATORIO  -  VEICULO                   *");
                           Console.WriteLine("**************************************************************");
                           //Chama o  metodo RELATORIO carro

                     break;
                 case '2': Console.WriteLine("**************************************************************");
                           Console.WriteLine("*                    RELATORIO  -  CLIENTE                   *");
                           Console.WriteLine("**************************************************************");
                           //Chamar metodo RELATORIO cliente

                     break;
                 case '3': 
                           Console.WriteLine("**************************************************************");
                           Console.WriteLine("*              RELATORIO       -     RENDA MENSAL            *");
                           Console.WriteLine("**************************************************************");
                           //Chamar metodo RELATORIO reda mensal
                     break;
                 case '4': Console.WriteLine("**************************************************************");
                           Console.WriteLine("*                    RELATORIO  -  CAIXA                     *");
                           Console.WriteLine("**************************************************************");
                          //Chamar metodo RELATORIO do caixa
                     break;

                 default: Console.WriteLine("Voce digitou uma opcao invalida! Tente novamente.");
                     break;
             }
         }

    }
}
