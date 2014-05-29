using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luis
{
    class Program
    {

        static int carroCadastrado = 0;
        static int clienteCadastrado = 0;
        static int constante = 20;
        static string opcao = null;
        static string Pesquisa = null;
        static int Achou = 0;

        static string[] Marca = new string[constante];
        static string[] Placa = new string[constante];
        static string[] Cor = new string[constante];
        static double[] Quilometragem = new double[constante];
        static string[] Situacao = new string[constante];
        static double[] Saldo = new double[constante];
        static int[] DiasLocado = new int[constante];

        static string[] Nome = new string[constante];
        static string[] RG = new string[constante];
        static string[] CPF = new string[constante];
        static string[,] Endereco = new string[7, constante];
        //Endereço: Linha 1 = Pais; Linha 2= Estado; Linha 3 =Cidade; Linha 4= Rua; Linha 5 = Bairro; Linha 6 = Numero; Linha 7 = Complemento

        static void Main(string[] args)
        {

            Console.Clear();

            //Chamando o método MENU
            Menu();

            Console.ReadKey();
        }

        static void CadastroCarro()
        {
            
            do
            {
                opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ INFORMACOES - VEICULO ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");

                Console.Write("Marca: ");
                Marca[carroCadastrado] = Console.ReadLine();
                do
                {
                    Console.Write("Placa: \t(XXX000)");
                    Placa[carroCadastrado] = Console.ReadLine();
                } while (Placa[carroCadastrado].Length != 6);
                Console.Write("Cor: ");
                Cor[carroCadastrado] = Console.ReadLine();
                Console.Write("Km Atual: ");
                Quilometragem[carroCadastrado] = double.Parse(Console.ReadLine());
                Situacao[carroCadastrado] = "Garagem";
                DiasLocado[carroCadastrado] = 0;
                carroCadastrado += 1;
                Console.Write("\n\nDeseja cadastrar outro automóvel ?     (S/N) ");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();

            } while (opcao != "n");
            Menu();
        }

        static void CadastroCliente()
        {
            
            
            do
            {
                Console.Clear();
                opcao = null;

                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ INFORMACOES - CLIENTE ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");

                Console.Write("Nome : ");
                Nome[clienteCadastrado] = Console.ReadLine();
                do
                {
                    Console.Write("RG : (10 digitos)");
                    RG[clienteCadastrado] = Console.ReadLine();
                } while (RG[clienteCadastrado].Length != 10);
                do
                {
                    Console.Write("CPF : (11 digitos)");
                    CPF[clienteCadastrado] = Console.ReadLine();
                } while (CPF[clienteCadastrado].Length != 11);
                Console.Write("Pais : ");
                Endereco[clienteCadastrado, 0] = Console.ReadLine();
                Console.Write("Estado : ");
                Endereco[clienteCadastrado, 1] = Console.ReadLine();
                Console.Write("Cidade : ");
                Endereco[clienteCadastrado, 2] = Console.ReadLine();
                Console.Write("Rua : ");
                Endereco[clienteCadastrado, 3] = Console.ReadLine();
                Console.Write("Bairro : ");
                Endereco[clienteCadastrado, 4] = Console.ReadLine();
                Console.Write("Numero : ");
                Endereco[clienteCadastrado, 5] = Console.ReadLine();
                Console.Write("Complemento : ");
                Endereco[clienteCadastrado, 6] = Console.ReadLine();
                Saldo[clienteCadastrado] = 0;
                clienteCadastrado += 1;
                Console.Write("\n\nDeseja cadastrar outro cliente ?     (S/N) ");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();

            } while (opcao != "n");
            Menu();


        }
        
        static void ConsultaCliente()
        {
            do
            {
                Pesquisa = null;
                Achou = 0;
                opcao = null;
                do
                {
                    Console.Clear();
                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ CONSULTA - CLIENTE ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓║");
                    Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");

                    Console.Write("Digite o CPF do cliente : ");
                    Pesquisa = Console.ReadLine();
                    if (Pesquisa.Length != CPF.Length)
                    {
                        Console.WriteLine("CPF invalido, digite no formato correto do CPF (11 digitos).");
                        continue;
                    }
                } while (Pesquisa.Length != CPF.Length);
                for (int i = 0; i < constante; i++)
                {
                    if (Pesquisa == CPF[i])
                    {
                        Console.WriteLine("\tNome.........: {0}", Nome[i]);
                        Console.WriteLine("\tRG...........: {0}", RG[i]);
                        Console.WriteLine("\tCPF..........: {0}", CPF[i]);
                        Console.WriteLine("\tPais.........: {0}", Endereco[i, 0]);
                        Console.WriteLine("\tEstado.......: {0}", Endereco[clienteCadastrado, 1]);
                        Console.WriteLine("\tCidade.......: {0}", Endereco[clienteCadastrado, 2]);
                        Console.WriteLine("\tRua..........: {0}", Endereco[clienteCadastrado, 3]);
                        Console.WriteLine("\tBairro.......: {0}", Endereco[clienteCadastrado, 4]);
                        Console.WriteLine("\tNumero.......: {0}", Endereco[clienteCadastrado, 5]);
                        Console.WriteLine("\tComplemento..: {0}", Endereco[clienteCadastrado, 6]);
                        Console.WriteLine("\tSaldo........: {0}", Saldo[i]);
                        Achou = 1;
                    }
                }
                if (Achou == 0)
                {
                    Console.WriteLine("Cliente não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja consultar outro cliente ?      (S/N)");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();

            } while (opcao != "n");
            Menu();
        }

        static void ConsultaCarro()
        {

            do
            {
                Pesquisa = null;
                Achou = 0;
                opcao = null;
                do
                {
                    Console.Clear();
                    Console.WriteLine("**************************************************************");
                    Console.WriteLine("*                    CONSULTA  -  VEICULO                    *");
                    Console.WriteLine("**************************************************************");
                    Console.Write("Digite a placa do carro : ");
                    Pesquisa = Console.ReadLine();
                    if (Pesquisa.Length != 6)
                    {
                        Console.WriteLine("Placa invalida, digite no formato correto da mesma (6 digitos, 3 letras e 3 numeros).");
                        continue;
                    }
                } while (Pesquisa.Length != 6);
                for (int i = 0; i < constante; i++)
                {
                    if (Pesquisa == Placa[i])
                    {
                        Console.WriteLine("Marca............: {0}", Marca[i]);
                        Console.WriteLine("Placa............: {0}", Placa[i]);
                        Console.WriteLine("Cor..............: {0}", Cor[i]);
                        Console.WriteLine("Km Atual.........: {0}", Quilometragem[i]);
                        Console.WriteLine("Situação.........: {0}", Situacao[i]);
                        Console.WriteLine("Disponibilidade..: {0} dias", DiasLocado[i]);
                        Achou = 1;

                    }
                }
                if (Achou == 0)
                {
                    Console.WriteLine("Carro não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja consultar outro carro ?      (S/N)");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();

            } while (opcao != "n");
            Menu();
        }

        static void TabelaPrecoCarros()
        {
            do
            {
                opcao = null;
                Console.Clear();
                Console.WriteLine("\t\t\t TABELA DE PREÇOS \n\n");
                for (int i = 0; i < carroCadastrado; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Placa............: {0}", Placa[i]);
                    Console.WriteLine("Cor..............: {0}", Cor[i]);
                    Console.WriteLine("Km Atual.........: {0}", Quilometragem[i]);
                    Console.WriteLine("Situação.........: {0}", Situacao[i]);
                    Console.WriteLine("Disponibilidade..: {0} dias", DiasLocado[i]);
                }
                Console.WriteLine("\n\nDeseja sair da tabela ?      (S/N)");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();

            } while (opcao != "s");
            Menu();
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
                          CadastroCarro();
                          break;
                case '2': 
                          //Chamar metodo cadastro cliente
                          CadastroCliente();
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
                           ConsultaCarro();
                     break;
                 case '2':                      //Chamar metodo CONSULTA cliente
                           ConsultaCliente();
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
