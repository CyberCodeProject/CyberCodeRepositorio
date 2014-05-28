using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateus
{
    class Program
    {        
        static void RemoverCarro()
        {
            int remover = 0;
            ConsultaCarro();
            if (Achou == 1)
            {
                Console.WriteLine("Tem certeza que deseja remover este carro? (S/N)");
                Resposta = Console.ReadLine();
                Resposta = Resposta.ToUpper();
                if (Resposta == "S")
                {
                    Tentativas = 3;
                    do{
                        Console.WriteLine("Digite a senha de usuario para confirmar: ");
                        SenhaTeste = Console.ReadLine();
                        Tentativas -=1;
                        for (int i = 0; i < 5; i++)
                        {
                            if (Senha[i] == SenhaTeste)
                            {
                                for (int j = posicao; j < CarroCadastrado; j++)
                                {
                                    Marca[i] = Marca[i + 1];
                                    Placa[i] = Placa[i + 1];
                                    Cor[i] = Cor[i + 1];
                                    Quilometragem[i] = Quilometragem[i + 1];
                                    Situacao[i] = Situacao[i + 1];
                                    DiasLocado[i] = DiasLocado[i + 1];
                                }
                                CarrosRemovidos += 1;
                                remover =1;
                                break;
                            }                                                                                                                 
                        }
                        if (remover == 0)
                        {
                            Console.WriteLine("Senha incorreta! Tente Novamente... (máximo 3 tentativas)");
                            if (Tentativas == 3)
                            {
                                Console.WriteLine("3 tentativas... Voce acabou de cancelar a remoção do carro.");
                            }  
                        }
                       
                    }while(Tentativas != 0 || remover!=1);
                }
            }
        }
        static void RemoverCliente()
        {
            int remover = 0;
            ConsultaCliente();
            if (Achou == 1)
            {
                Console.WriteLine("Tem certeza que deseja remover este cliente? (S/N)");
                Resposta = Console.ReadLine();
                Resposta = Resposta.ToUpper();
                if (Resposta == "S")
                {
                    Tentativas = 3;
                    do
                    {
                        Console.WriteLine("Digite a senha de usuario para confirmar: ");
                        SenhaTeste = Console.ReadLine();
                        Tentativas -= 1;
                        for (int i = 0; i < 5; i++)
                        {
                            if (Senha[i] == SenhaTeste)
                            {
                                for (int j = posicao; j < ClienteCadastrado; j++)
                                {                                    
                                    Nome[i] = Nome[i+1];
                                    RG[i] =  RG[i+1];
                                    CPF[i] = CPF[i+1];
                                    for(int j =0; j<7;j++){
                                        Endereco[i,j] = Endereco[i+1,j];
                                    }
                                }
                                ClientesRemovidos += 1;
                                remover = 1;
                                break;
                            }
                        }
                        if (remover == 0)
                        {
                            Console.WriteLine("Senha incorreta! Tente Novamente... (máximo 3 tentativas)");
                            if (Tentativas == 3)
                            {
                                Console.WriteLine("3 tentativas... Voce acabou de cancelar a remoção do cliente.");
                            }
                        }

                    } while (Tentativas != 0 || remover != 1);
                }
            }
        }
    }
}
