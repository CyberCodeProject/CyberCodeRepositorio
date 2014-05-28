using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greicy
{
    class Program
    {
        static int carroCadastrado = 0;
        static int clienteCadastrado = 0;
        static int constante = 20;
        static string opcao = null;
        static string Pesquisa = null;
        static int Achou = 0;
        static string Resposta = null;
        static string SenhaTeste = null;

        static string[] Marca = new string[constante];
        static string[] Placa = new string[constante];
        static string[] Cor = new string[constante];
        static double[] Quilometragem = new double[constante];
        static string[] Situacao = new string[constante];
        static double[] Saldo = new double[constante];
        static int[] DiasLocado = new int[constante];
        static double[] ValorDiaria = new double[constante];

        static string[] Nome = new string[constante];
        static string[] RG = new string[constante];
        static string[] CPF = new string[constante];        
        static string[,] Endereco = new string[7,constante];
        //Endereço: Linha 1 = Pais; Linha 2= Estado; Linha 3 =Cidade; Linha 4= Rua; Linha 5 = Bairro; Linha 6 = Numero; Linha 7 = Complemento


        static void cadastroCarro()
        {            
            do{
                opcao = null;
                Console.Clear();
                Console.WriteLine("\t\tCadastrando um novo Carro \n\n");
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
                Console.WriteLine("Qual o valor da diária deste carro ?");
                ValorDiaria[carroCadastrado] = double.Parse(Console.ReadLine());
                carroCadastrado +=1;
                Console.Write("\n\nDeseja cadastrar outro automóvel ?     (S/N) ");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();
                
            }while( opcao != "n");
        }
        static void cadastroCliente(){
            do{
                Console.Clear();
                opcao = null;
                Console.WriteLine("\t\t\t CADASTRO CLIENTE :\n\n");
                Console.Write("Nome : ");
                Nome[clienteCadastrado] = Console.ReadLine();
                do
                {
                    Console.Write("RG : (10 digitos)");
                    RG[clienteCadastrado] = Console.ReadLine();
                } while (RG[clienteCadastrado].Length != 10 );
                do
                {
                    Console.Write("CPF : (11 digitos)");
                    CPF[clienteCadastrado] = Console.ReadLine();
                } while (CPF[clienteCadastrado].Length != 11);
                Console.Write("Pais : ");
                Endereco[clienteCadastrado,0] = Console.ReadLine();
                Console.Write("Estado : ");
                Endereco[clienteCadastrado,1] = Console.ReadLine();
                Console.Write("Cidade : ");
                Endereco[clienteCadastrado,2] = Console.ReadLine();
                Console.Write("Rua : ");
                Endereco[clienteCadastrado,3] = Console.ReadLine();
                Console.Write("Bairro : ");
                Endereco[clienteCadastrado,4] = Console.ReadLine();
                Console.Write("Numero : ");
                Endereco[clienteCadastrado,5] = Console.ReadLine();
                Console.Write("Complemento : ");
                Endereco[clienteCadastrado,6] = Console.ReadLine();
                Saldo[clienteCadastrado] = 0;
                clienteCadastrado += 1;
                Console.Write("\n\nDeseja cadastrar outro cliente ?     (S/N) ");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();
                
            }while( opcao != "n");
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
                    Console.WriteLine("\t\t\t CONSULTA DE CLIENTE :\n\n");
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
        }

        static void ConsultaCarros()
        {

            do{               
                Pesquisa = null;
                Achou = 0;
                opcao = null;
                do {
                    Console.Clear();
                    Console.WriteLine("\t\t\t CONSULTA DE CARRO :\n\n");
                    Console.Write("Digite a placa do carro : ");
                    Pesquisa = Console.ReadLine();
                    if (Pesquisa.Length != 6){
                        Console.WriteLine("Placa invalida, digite no formato correto da mesma (6 digitos, 3 letras e 3 numeros).");
                        continue;
                    }
                }while(Pesquisa.Length != 6);
                for(int i=0; i<constante;i++){
                    if (Pesquisa == Placa[i]){
                        Console.WriteLine("Marca............: {0}",Marca[i]);
                        Console.WriteLine("Placa............: {0}",Placa[i]);
                        Console.WriteLine("Cor..............: {0}",Cor[i]);
                        Console.WriteLine("Km Atual.........: {0}",Quilometragem[i]);
                        Console.WriteLine("Situação.........: {0}",Situacao[i]);
                        Console.WriteLine("Disponibilidade..: {0} dias",DiasLocado[i]);
                        Console.WriteLine("Valor Diária.....: {0}", ValorDiaria[i]);
                        Achou = 1;

                     }
                }
                if (Achou == 0){
                    Console.WriteLine("Carro não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja consultar outro carro ?      (S/N)");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();
                
            }while( opcao != "n");               
        }

        static void TabelaPrecoCarros()
        {
            do{
                opcao = null;
                Console.Clear();
                Console.WriteLine("\t\t\t TABELA DE PREÇOS \n\n");
                for (int i = 0; i < carroCadastrado; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}",Marca[i]);
                    Console.WriteLine("Placa............: {0}",Placa[i]);
                    Console.WriteLine("Cor..............: {0}",Cor[i]);
                    Console.WriteLine("Valor Diária.....: {0}",ValorDiaria[i]);
                }
                Console.WriteLine("\n\nDeseja sair da tabela ?      (S/N)");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();
                
            }while( opcao != "s");
        }

        static void SituacaoDosCarros()
        {
            opcao = null;
            Console.Clear();
            Console.WriteLine("\t\t\t SITUAÇÃO DOS CARROS \n\n");

            do{
                for (int i = 0; i < carroCadastrado; i++)
                {
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Local............: {0}", Situacao[i]);
                    Console.WriteLine("Disponivel em....: {0} dias", DiasLocado[i]+1); 
                }
                Console.WriteLine("\n\nDeseja sair da tabela ?      (S/N)");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();
                
            }while( opcao != "s");
        }
        static void Main(string[] args)
        {
            cadastroCarro();
            cadastroCliente();
            ConsultaCarros();
            ConsultaCliente();
            TabelaPrecoCarros();

        }
    }
}
