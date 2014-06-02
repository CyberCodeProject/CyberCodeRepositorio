
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprigio
{
    class Program
    {
        //Variaveis Globais
        static int CarroCadastrado = 0;
        static int ClienteCadastrado = 0;
        static int constante = 20;
        static string Opcao = null;
        static string Pesquisa = null;
        static int Achou = 0;
        static string Resposta = null;
        static string SenhaTeste = null;
        static int Posicao = 0;
        static int Tentativas = 3;
        static int CarrosRemovidos, ClientesRemovidos = 0;
        static double RendaMensal = 12234;
        static double RendaCaixa = 2435;
        static int PosicaoCliente = 0;
        static string[] Usuarios = { "aprigio", "luis", "mateus", "greicy", "thiago" };
        static int garagem = 0;
        static int rodando = 0;
        static int reservado = 0;
         // Variaveis Relacionadas aos Carros

        static string[] Marca = new string[constante];
        static string[] Placa = new string[constante];
        static string[] Cor = new string[constante];
        static double[] Quilometragem = new double[constante];
        static string[] Situacao = new string[constante];
        static int[] DiasLocado = new int[constante];
        static double[] ValorDiaria = new double[constante];

        // Variaveis Relacionadas aos Clientes

        static string[] Nome = new string[constante];
        static double[] Saldo = new double[constante];
        static string[] Carro = new string[constante];
        static string[] RG = new string[constante];
        static string[] CPF = new string[constante];
        static string[,] Endereco = new string[7, constante];
        static void Main()
        {
            MenuAjuda();
        }

        public static void MenuAjuda()
        {

          Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
          Console.WriteLine("║                              MENU AJUDA                                     ║");
          Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝\n");

          Console.WriteLine("Passo a Passo para acesso ao Sistema\n");
                 
          Console.WriteLine("1. Login e Senha");

          Console.WriteLine("Para acessar o Sistema insira o login e senha para identificação do funcionário."); 

          Console.WriteLine("2. Cadastro Cliente: Nome, CPF e Endereço.");

          Console.WriteLine("Para Cadastro do cliente informe os dados pessoais é o endereço.\n"); 

          Console.WriteLine("3. Cadastro Automóvel: MARCA, PLACA, KM inicial e KM final");

          Console.WriteLine("Insira os dados do Automóvel para obter o valor do aluguel é se o automóvel se"); 
          Console.WriteLine("encontra na garagem.\n");  
    
          Console.WriteLine("4. Consultas: Automóvel e Cliente"); 
        
          Console.WriteLine("Dados de consulta Automóvel rodando, Automóvel na garagem."); 
 
          Console.WriteLine("Dados do Cliente");

          Console.WriteLine("Tabela de Preços dos Automóveis\n");
 
          Console.WriteLine("5. Movimento: Movimento Diário");

          Console.WriteLine("Controle de Locação");

          Console.WriteLine("Controle de Devolução");

          Console.WriteLine("Reserva: No ato de locação, informar se o cliente está bloqueado, se o cliente");
          Console.WriteLine("já locou ou está devendo, se o carro está reservado.\n");

          Console.WriteLine("6. Alteração: Automóvel e Cliente ");
          Console.WriteLine("Altera os dados do Automóvel");
          Console.WriteLine("Altera os dados do Cliente\n");

          Console.WriteLine("7. Remoção: Automóvel");
          Console.WriteLine("Remove Automóvel fora de linha ou com defeito\n");

          Console.WriteLine("8. Relatório: Cliente, Automóvel e Funcionario");
          Console.WriteLine("Dados do Cliente");
          Console.WriteLine("Dados do Automóvel");
          Console.WriteLine("Dados da Locação");
          Console.WriteLine("Dados do Funcionário Cadastrado");
          Console.ReadKey();
        }

        static void ConsultaCliente()
        {
            do
            {
                Pesquisa = null;
                Achou = 0;
                Opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░ CONSULTA - CLIENTE ░░░░░░░░░░░░░░░░░░░░░░░░░░║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
                Console.Write("Digite o CPF do cliente : ");
                Pesquisa = Console.ReadLine();
                if (Pesquisa.Length != 11)
                {
                    Console.WriteLine("CPF invalido, digite no formato correto do CPF (11 digitos).");
                    Console.ReadKey();
                    continue;
                }
                for (int i = 0; i < constante; i++)
                {
                    if (Pesquisa == CPF[i])
                    {
                        Console.WriteLine("\tNome.........: {0}", Nome[i]);
                        Console.WriteLine("\tRG...........: {0}", RG[i]);
                        Console.WriteLine("\tCPF..........: {0}", CPF[i]);
                        Console.WriteLine("\tPais.........: {0}", Endereco[i, 0]);
                        Console.WriteLine("\tEstado.......: {0}", Endereco[i, 1]);
                        Console.WriteLine("\tCidade.......: {0}", Endereco[i, 2]);
                        Console.WriteLine("\tRua..........: {0}", Endereco[i, 3]);
                        Console.WriteLine("\tBairro.......: {0}", Endereco[i, 4]);
                        Console.WriteLine("\tNumero.......: {0}", Endereco[i, 5]);
                        Console.WriteLine("\tComplemento..: {0}", Endereco[i, 6]);
                        Console.WriteLine("\tSaldo........: {0}", Saldo[i]);
                        Achou = 1;
                        Posicao = i;
                    }
                }
                if (Achou == 0)
                {
                    Console.WriteLine("Cliente não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja realizar outra pesquisa?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }

        static void ConsultaCarros()
        {

            do
            {
                Pesquisa = null;
                Achou = 0;
                Opcao = null;
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║░░░░░░░░░░░░░░░░░░░░░░░░░░ CONSULTA - VEICULO ░░░░░░░░░░░░░░░░░░░░░░░░░░║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════╝");
                Console.Write("Digite a placa do carro : ");
                Pesquisa = Console.ReadLine();
                if (Pesquisa.Length != 6)
                {
                    Console.WriteLine("Placa invalida, digite no formato correto da mesma (6 digitos, 3 letras e 3 numeros).");
                    continue;
                }
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos; i++)
                {
                    if (Pesquisa == Placa[i])
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("\tMarca............: {0}", Marca[i]);
                        Console.WriteLine("\tPlaca............: {0}", Placa[i]);
                        Console.WriteLine("\tCor..............: {0}", Cor[i]);
                        Console.WriteLine("\tKm Atual.........: {0}", Quilometragem[i]);
                        Console.WriteLine("\tSituação.........: {0}", Situacao[i]);
                        Console.WriteLine("\tDisponivel em....: {0} dias", DiasLocado[i]);
                        Console.WriteLine("\tValor Diária.....: {0} R$", ValorDiaria[i]);
                        Achou = 1;
                        Posicao = i;

                    }
                }
                if (Achou == 0)
                {
                    Console.WriteLine("Carro não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja realizar outra pesquisa?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }
        static void AlterarCliente()
        {
            ConsultaCliente();
            if (Achou == 1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine(" ");
                    Console.WriteLine("\t'1' - Nome.........: {0}", Nome[Posicao]);
                    Console.WriteLine("\t'2' - RG...........: {0}", RG[Posicao]);
                    Console.WriteLine("\t'3' - CPF..........: {0}", CPF[Posicao]);
                    Console.WriteLine("\t'4' - Pais.........: {0}", Endereco[Posicao, 0]);
                    Console.WriteLine("\t'5' - Estado.......: {0}", Endereco[Posicao, 1]);
                    Console.WriteLine("\t'6' - Cidade.......: {0}", Endereco[Posicao, 2]);
                    Console.WriteLine("\t'7' - Rua..........: {0}", Endereco[Posicao, 3]);
                    Console.WriteLine("\t'8' - Bairro.......: {0}", Endereco[Posicao, 4]);
                    Console.WriteLine("\t'9' - Numero.......: {0}", Endereco[Posicao, 5]);
                    Console.WriteLine("\t'10' - Complemento..: {0}", Endereco[Posicao, 6]);
                    Console.WriteLine("\t'11' - Saldo........: {0}", Saldo[Posicao]);
                    Console.WriteLine("\t'12' - Sair.");
                    Console.WriteLine("\nO que você deseja alterar?");
                    Opcao = Console.ReadLine();
                    switch (Opcao)
                    {
                        case "1":
                            Console.Write("Novo: ");
                            Nome[Posicao] = Console.ReadLine();
                            break;
                        case "2":
                            Console.Write("Novo: ");
                            RG[Posicao] = Console.ReadLine();
                            break;
                        case "3":
                            Console.Write("Novo: ");
                            CPF[Posicao] = Console.ReadLine();
                            break;
                        case "4":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 0] = Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 1] = Console.ReadLine();
                            break;
                        case "6":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 2] = Console.ReadLine();
                            break;
                        case "7":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 3] = Console.ReadLine();
                            break;
                        case "8":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 4] = Console.ReadLine();
                            break;
                        case "9":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 5] = Console.ReadLine();
                            break;
                        case "10":
                            Console.Write("Novo: ");
                            Endereco[Posicao, 6] = Console.ReadLine();
                            break;
                        case "11":
                            Console.Write("Novo: ");
                            Saldo[Posicao] = double.Parse(Console.ReadLine());
                            break;
                        default: Console.WriteLine("Opção incorreta! Digite novamente!");
                            continue;
                    }
                } while (Opcao != "12");
            }
        }
        static void AlterarCarro()
        {
            ConsultaCarros();
            if (Achou == 1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t'1' - Marca............: {0}", Marca[Posicao]);
                    Console.WriteLine("\t'2' - Placa............: {0}", Placa[Posicao]);
                    Console.WriteLine("\t'3' - Cor..............: {0}", Cor[Posicao]);
                    Console.WriteLine("\t'4' - Km Atual.........: {0}", Quilometragem[Posicao]);
                    Console.WriteLine("\t'5' - Situação.........: {0}", Situacao[Posicao]);
                    Console.WriteLine("\t'6' - Disponibilidade..: {0} dias", DiasLocado[Posicao]);
                    Console.WriteLine("\t'7' - Valor Diária.....: {0}", ValorDiaria[Posicao]);
                    Console.WriteLine("\t'8' - Sair.");
                    Console.WriteLine("\nO que você deseja alterar?");
                    Opcao = Console.ReadLine();
                    switch (Opcao)
                    {
                        case "1":
                            Console.Write("Novo: ");
                            Marca[Posicao] = Console.ReadLine();
                            break;
                        case "2":
                            do
                            {
                                Console.Write("Novo: ");
                                Console.WriteLine("(XXX-000): ");
                                Placa[Posicao] = Console.ReadLine();
                                if (Placa[Posicao].Length != 6)
                                {
                                    Console.WriteLine("Placa invalida. Digite novamente com 6 digitos!");
                                }
                            } while (Placa[Posicao].Length != 6);
                            break;
                        case "3":
                            Console.Write("Novo: ");
                            Cor[Posicao] = Console.ReadLine();
                            break;
                        case "4":
                            Console.Write("Novo: ");
                            Quilometragem[Posicao] = double.Parse(Console.ReadLine());
                            break;
                        case "5":
                            do
                            {
                                Console.WriteLine("(Garagem - Rodando - Reservado): ");
                                Situacao[Posicao] = Console.ReadLine();
                            } while (Situacao[Posicao] != "Garagem" || Situacao[Posicao] != "Rodando" || Situacao[Posicao] != "Reservado");
                            break;
                        case "6":
                            Console.Write("Novo: ");
                            DiasLocado[Posicao] = int.Parse(Console.ReadLine());
                            break;
                        case "7":
                            Console.Write("Novo: ");
                            ValorDiaria[Posicao] = double.Parse(Console.ReadLine());
                            break;
                        default: Console.WriteLine("Opção incorreta! Digite novamente!");
                            continue;
                    }
                } while (Opcao != "8");
            }
        }
    }
}
