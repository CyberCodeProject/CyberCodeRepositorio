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
        static string[] Marca = new string[constante];
        static string[] Placa = new string[constante];
        static string[] Cor = new string[constante];
        static double[] Quilometragem = new double[constante];
        static string[] Nome = new string[constante];
        static string[] RG = new string[constante];
        static string[] CPF = new string[constante];        
        static string[,] Endereco = new string[7,constante];
        static double[] Saldo = new double[constante];
        //Endereço: Linha 1 = Pais; Linha 2= Estado; Linha 3 =Cidade; Linha 4= Rua; Linha 5 = Bairro; Linha 6 = Numero; Linha 7 = Complemento
        static void cadastroCarro()
        {            
            do{
                opcao = null;
                Console.Clear();
                Console.WriteLine("\t\tCadastrando um novo carro no sistema...\n\n");
                Console.Write("Marca: ");
                Marca[carroCadastrado] = Console.ReadLine();
                Console.Write("Placa: \t(XXX-000)");
                Placa[carroCadastrado] = Console.ReadLine();
                Console.Write("Cor: ");
                Cor[carroCadastrado] = Console.ReadLine();
                Console.Write("Km Atual: ");
                Quilometragem[carroCadastrado] = double.Parse(Console.ReadLine());
                carroCadastrado +=1;
                Console.Write("\n\nDeseja cadastrar outro automóvel ?     (S/N) ");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();
                
            }while( opcao != "n");
           // Menu();
        }
        static void cadastroCliente(){
            do{
                Console.Clear();
                opcao = null;
                Console.WriteLine("\t\tCadastrando novo Cliente :\n\n");
                Console.Write("Nome : ");
                Nome[clienteCadastrado] = Console.ReadLine();
                Console.Write("RG : ");
                RG[clienteCadastrado] = Console.ReadLine();
                Console.Write("CPF : ");
                CPF[clienteCadastrado] = Console.ReadLine();
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
           // Menu();


        }
        static void Main(string[] args)
        {
            cadastroCarro();
            cadastroCliente();
        }
    }
}
