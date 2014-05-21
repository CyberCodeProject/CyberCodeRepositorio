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
        static int constante = 20;
        static string[] Marca = new string[constante];
        static string[] Placa = new string[constante];
        static string[] Cor = new string[constante];
        static double[] Quilometragem = new double[constante];
        static string[] Nome = new string[constante];
        static string[] RG = new string[constante];
        static string[] CPF = new string[constante];        
        static string[,] Endereco = new string[7,constante]; 
        //Endereço: Linha 1 = Pais; Linha 2= Estado; Linha 3 =Cidade; Linha 4= Rua; Linha 5 = Bairro; Linha 6 = Numero; Linha 7 = Complemento
        static void cadastroCarro()
        {            
            do{
                Console.WriteLine("\t\tCadastrando um novo carro no sistema...\n\n");
                Console.WriteLine("Marca: ");
                Marca[carroCadastrado] = Console.ReadLine();
                Console.WriteLine("Placa: \t(XXX-000)");
                Placa[carroCadastrado] = Console.ReadLine();
                Console.WriteLine("Cor: ");
                Cor[carroCadastrado] = Console.ReadLine();
                Console.WriteLine("Km Atual: ");
                Quilometragem[carroCadastrado] = double.Parse(Console.ReadLine());
                carroCadastrado +=1;
                
            }while();
        }
        static void cadastroCliente(){

        }
        static void Main(string[] args)
        {
            cadastroCarro();
        }
    }
}
