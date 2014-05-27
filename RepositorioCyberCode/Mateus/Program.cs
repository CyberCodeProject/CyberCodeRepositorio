using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus
{
    class Program
    {


        
        static void ConsultaCliente()
        {
            do{
                Console.Clear();
                static string Pesquisa = null;
                static int Achou = 0;
                opcao = null;
                do{
                    Console.WriteLine("\t\t\t CONSULTA DE CLIENTE :\n");
                    Console.Write("Digite o CPF do cliente : ");
                    Pesquisa = Console.ReadLine();
                    if (Pesquisa.Length != CPF.Length){
                        Console.WriteLine("CPF invalido, digite no formato correto do CPF (11 digitos).");
                    }
                }while(Pesquisa.Length != CPF.Length);
                for(int i=0; i<constante;i++){
                    if (Pesquisa == CPF[i]){
                        Console.WriteLine("\tNome.........: {0}",Nome[i]);
                        Console.WriteLine("\tRG...........: {0}",RG[i]);
                        Console.WriteLine("\tCPF..........: {0}",CPF[i]);
                        Console.WriteLine("\tPais.........: {0}",Endereco[i,0]);
                        Console.WriteLine("\tEstado.......: {0}",Endereco[clienteCadastrado,1]);
                        Console.WriteLine("\tCidade.......: {0}",Endereco[clienteCadastrado,2]);
                        Console.WriteLine("\tRua..........: {0}",Endereco[clienteCadastrado,3]);
                        Console.WriteLine("\tBairro.......: {0}",Endereco[clienteCadastrado,4]);
                        Console.WriteLine("\tNumero.......: {0}",Endereco[clienteCadastrado,5]);
                        Console.WriteLine("\tComplemento..: {0}",Endereco[clienteCadastrado,6]);
                        Console.WriteLine("\tSaldo........: {0}",Saldo[i]);
                        Achou = 1;
                    }         
                }
                if (Achou == 0){
                    Console.WriteLine("Cliente não cadastrado.");
                }
                Console.WriteLine("\n\nDeseja consultar outro cliente ?      (S/N)");
                opcao = Console.ReadLine();
                opcao = opcao.ToLower();
                
            }while( opcao != "n");
            Menu();











            
            













        }









        static void Main(string[] args)
        {
        }
    }
}
