using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greicy
{
    class Program
    {
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

        static string[] Marca = new string[constante];
        static string[] Placa = new string[constante];
        static string[] Cor = new string[constante];
        static double[] Quilometragem = new double[constante];
        static string[] Situacao = new string[constante];
        static int[] DiasLocado = new int[constante];
        static double[] ValorDiaria = new double[constante];

        static string[] Nome = new string[constante];
        static double[] Saldo = new double[constante];
        static string[] RG = new string[constante];
        static string[] CPF = new string[constante];        
        static string[,] Endereco = new string[7,constante];
        //Endereço: Linha 1 = Pais; Linha 2= Estado; Linha 3 =Cidade; Linha 4= Rua; Linha 5 = Bairro; Linha 6 = Numero; Linha 7 = Complemento


        static void cadastro_Carro()
        {            
            do{
                Opcao = null;
                Console.Clear();
                Console.WriteLine("\t\tCadastrando um novo Carro \n\n");
                Console.Write("Marca: ");
                Marca[CarroCadastrado] = Console.ReadLine();
                do
                {
                    Console.Write("Placa: \t(XXX000)");
                    Placa[CarroCadastrado] = Console.ReadLine();
                } while (Placa[CarroCadastrado].Length != 6);
                Console.Write("Cor: ");
                Cor[CarroCadastrado] = Console.ReadLine();
                Console.Write("Km Atual: ");
                Quilometragem[CarroCadastrado] = double.Parse(Console.ReadLine());
                Situacao[CarroCadastrado] = "Garagem";
                DiasLocado[CarroCadastrado] = 0;
                Console.WriteLine("Qual o valor da diária deste carro ?");
                ValorDiaria[CarroCadastrado] = double.Parse(Console.ReadLine());
                CarroCadastrado +=1;
                Console.Write("\n\nDeseja cadastrar outro automóvel ?     (S/N) ");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
                
            }while( Opcao != "n");
        }
        static void cadastro_Cliente(){
            do{
                Console.Clear();
                Opcao = null;
                Console.WriteLine("\t\t\t CADASTRO CLIENTE :\n\n");
                Console.Write("Nome : ");
                Nome[ClienteCadastrado] = Console.ReadLine();
                do
                {
                    Console.Write("RG : (10 digitos)");
                    RG[ClienteCadastrado] = Console.ReadLine();
                } while (RG[ClienteCadastrado].Length != 10 );
                do
                {
                    Console.Write("CPF : (11 digitos)");
                    CPF[ClienteCadastrado] = Console.ReadLine();
                } while (CPF[ClienteCadastrado].Length != 11);
                Console.Write("Pais : ");
                Endereco[ClienteCadastrado,0] = Console.ReadLine();
                Console.Write("Estado : ");
                Endereco[ClienteCadastrado,1] = Console.ReadLine();
                Console.Write("Cidade : ");
                Endereco[ClienteCadastrado,2] = Console.ReadLine();
                Console.Write("Rua : ");
                Endereco[ClienteCadastrado,3] = Console.ReadLine();
                Console.Write("Bairro : ");
                Endereco[ClienteCadastrado,4] = Console.ReadLine();
                Console.Write("Numero : ");
                Endereco[ClienteCadastrado,5] = Console.ReadLine();
                Console.Write("Complemento : ");
                Endereco[ClienteCadastrado,6] = Console.ReadLine();
                Saldo[ClienteCadastrado] = 0;
                ClienteCadastrado += 1;
                Console.Write("\n\nDeseja cadastrar outro cliente ?     (S/N) ");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
                
            }while( Opcao != "n");
        }

        static void Consulta_Cliente()
        {
            do
            {
                Pesquisa = null;
                Achou = 0;
                Opcao = null;
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
                        Console.WriteLine("\tEstado.......: {0}", Endereco[ClienteCadastrado, 1]);
                        Console.WriteLine("\tCidade.......: {0}", Endereco[ClienteCadastrado, 2]);
                        Console.WriteLine("\tRua..........: {0}", Endereco[ClienteCadastrado, 3]);
                        Console.WriteLine("\tBairro.......: {0}", Endereco[ClienteCadastrado, 4]);
                        Console.WriteLine("\tNumero.......: {0}", Endereco[ClienteCadastrado, 5]);
                        Console.WriteLine("\tComplemento..: {0}", Endereco[ClienteCadastrado, 6]);
                        Console.WriteLine("\tSaldo........: {0}", Saldo[i]);
                        Achou = 1;
                        Posicao = i;
                    }
                }
                if (Achou == 0)
                {
                    Console.WriteLine("Cliente não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja consultar outro cliente ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }

        static void Consulta_Carros()
        {

            do{               
                Pesquisa = null;
                Achou = 0;
                Opcao = null;
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
                        Console.WriteLine("\tMarca............: {0}",Marca[i]);
                        Console.WriteLine("\tPlaca............: {0}",Placa[i]);
                        Console.WriteLine("\tCor..............: {0}",Cor[i]);
                        Console.WriteLine("\tKm Atual.........: {0}",Quilometragem[i]);
                        Console.WriteLine("\tSituação.........: {0}",Situacao[i]);
                        Console.WriteLine("\tDisponibilidade..: {0} dias",DiasLocado[i]);
                        Console.WriteLine("\tValor Diária.....: {0}", ValorDiaria[i]);
                        Achou = 1;
                        Posicao = i;

                     }
                }
                if (Achou == 0){
                    Console.WriteLine("Carro não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja consultar outro carro ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
                
            }while( Opcao != "n");               
        }

        static void Tabela_Preco_Carros()
        {
            do{
                Opcao = null;
                Console.Clear();
                Console.WriteLine("\t\t\t TABELA DE PREÇOS \n\n");
                for (int i = 0; i < CarroCadastrado; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}",Marca[i]);
                    Console.WriteLine("Placa............: {0}",Placa[i]);
                    Console.WriteLine("Cor..............: {0}",Cor[i]);
                    Console.WriteLine("Valor Diária.....: {0}",ValorDiaria[i]);
                }
                Console.WriteLine("\n\nDeseja sair da tabela ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
                
            }while( Opcao != "s");
        }

        static void Situacao_Dos_Carros()
        {
            Console.WriteLine("\t\t\t SITUAÇÃO DOS CARROS \n\n");
            do{
                Opcao = null;
                Console.Clear();
                for (int i = 0; i < CarroCadastrado; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Local............: {0}", Situacao[i]);
                    Console.WriteLine("Disponivel em....: {0} dias", DiasLocado[i]+1); 
                }
                Console.WriteLine("\n\nDeseja sair ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
                
            }while( Opcao != "s");
        }

        static void Relatorio_Cliente()
        {
            Console.WriteLine("\t\t\t RELATORIO SOBRE CLIENTES :\n\n");
            do{
                Opcao = null;
                Console.Clear();
                for(int i=0;i<ClienteCadastrado;i++){
                    Console.WriteLine("\nNome.........: {0}", Nome[i]);
                    Console.WriteLine("RG...........: {0}", RG[i]);
                    Console.WriteLine("CPF..........: {0}", CPF[i]);
                    Console.WriteLine("Pais.........: {0}", Endereco[i, 0]);
                    Console.WriteLine("Estado.......: {0}", Endereco[ClienteCadastrado, 1]);
                    Console.WriteLine("Cidade.......: {0}", Endereco[ClienteCadastrado, 2]);
                    Console.WriteLine("Rua..........: {0}", Endereco[ClienteCadastrado, 3]);
                    Console.WriteLine("Bairro.......: {0}", Endereco[ClienteCadastrado, 4]);
                    Console.WriteLine("Numero.......: {0}", Endereco[ClienteCadastrado, 5]);
                    Console.WriteLine("Complemento..: {0}", Endereco[ClienteCadastrado, 6]);
                    Console.WriteLine("Saldo........: {0}", Saldo[i]);
                }
                Console.WriteLine("\n\nDeseja sair da consulta ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
            } while (Opcao != "s");
        }

        static void Relatorio_Carro()
        {
            Console.WriteLine("\t\t\t RELATORIO SOBRE CARROS :\n\n");
            do{
                Opcao = null;
                Console.Clear();
                for (int i = 0; i < CarroCadastrado; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Placa............: {0}", Placa[i]);
                    Console.WriteLine("Cor..............: {0}", Cor[i]);
                    Console.WriteLine("Km Atual.........: {0}", Quilometragem[i]);
                    Console.WriteLine("Situação.........: {0}", Situacao[i]);
                    Console.WriteLine("Disponibilidade..: {0} dias", DiasLocado[i]);
                    Console.WriteLine("Valor Diária.....: {0}", ValorDiaria[i]);
                }
                Console.WriteLine("\n\nDeseja sair da consulta ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
            } while (Opcao != "s");
        }




        static void Main(string[] args)
        {
            cadastro_Carro();
            cadastro_Cliente();
            Consulta_Carros();
            Consulta_Cliente();
            Tabela_Preco_Carros();
            Situacao_Dos_Carros();

        }
    }
}
