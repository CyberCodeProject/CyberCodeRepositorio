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
                Console.WriteLine("Tem certeza que deseja remover este carro?");
                do{
                    Console.WriteLine("S/N)");
                    Resposta = Console.ReadLine();
                    Resposta = Resposta.ToUpper();
                    if (Resposta != 'S' && Resposta != 'N')
                    {
                        Console.WriteLine("Resposta incorreta, digite novamente! ");
                    }
                }while(Resposta != 'S' && Resposta != 'N');
                if (Resposta == "S")
                {
                    Tentativas = 3;
                    do{
                        Console.WriteLine("Digite a senha de usuario para confirmar: ");
                        SenhaTeste = Console.ReadLine();
                        Tentativas -=1;
                        for (int i = 0; i < 5; i++)
                        {
                            if (Usuarios[i]+"123" == SenhaTeste)
                            {
                                for (int j = Posicao; j < CarroCadastrado; j++)
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
                Console.WriteLine("Tem certeza que deseja remover este cliente?");
                do{
                    Console.WriteLin("(S/N)");
                    Resposta = Console.ReadLine();
                    Resposta = Resposta.ToUpper();
                    if (Resposta != 'S' && Resposta != 'N')
                    {
                        Console.WriteLine("Resposta incorreta, digite novamente! ");
                    }
                } while (Resposta != 'S' && Resposta != 'N');
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
                            if (Usuarios[i]+"123" == SenhaTeste)
                            {
                                for (int j = Posicao; j < ClienteCadastrado; j++)
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
        static void AlterarCliente()
        {
            ConsultarCliente();
            if (Achou == 1)
            {
                do{
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
                        case "1": Nome[Posicao] = Console.ReadLine();
                            break;
                       case "2": RG[Posicao] = Console.ReadLine();
                           break;
                       case "3": CPF[Posicao] = Console.ReadLine();
                           break;
                       case "4": Endereco[Posicao, 0] = Console.ReadLine();
                           break;
                       case "5": Endereco[Posicao, 1] = Console.ReadLine();
                           break;
                       case "6": Endereco[Posicao, 2] = Console.ReadLine();
                           break;
                       case "7": Endereco[Posicao, 3] = Console.ReadLine();
                           break;
                       case "8": Endereco[Posicao, 4] = Console.ReadLine();
                           break;
                       case "9": Endereco[Posicao, 5] = Console.ReadLine();
                           break;
                       case "10" : Endereco[Posicao, 6] = Console.ReadLine();
                           break;
                       case "11" : Saldo[Posicao] = Console.ReadLine();
                           break;
                       default: Console.WriteLine("Opção incorreta! Digite novamente!");
                           continue;
                    }
                }while(Opcao != "12");
            }                                                   
        }
        static void AlterarCarro()
        {
            ConsultarCarro();
            if (Achou == 1)
            {
                do
                {
                    Console.WriteLine("\t'1' - Marca............: {0}", Marca[i]);
                    Console.WriteLine("\t'2' - Placa............: {0}", Placa[i]);
                    Console.WriteLine("\t'3' - Cor..............: {0}", Cor[i]);
                    Console.WriteLine("\t'4' - Km Atual.........: {0}", Quilometragem[i]);
                    Console.WriteLine("\t'5' - Situação.........: {0}", Situacao[i]);
                    Console.WriteLine("\t'6' - Disponibilidade..: {0} dias", DiasLocado[i]);
                    Console.WriteLine("\t'7' - Valor Diária.....: {0}", ValorDiaria[i]);
                    Console.WriteLine("\t'8' - Sair.");
                    Console.WriteLine("\nO que você deseja alterar?");
                    Opcao = Console.ReadLine();
                    switch (Opcao)
                    {
                        case "1": Marca[Posicao] = Console.ReadLine();
                            break;
                        case "2": Placa[Posicao] = Console.ReadLine();
                            break;
                        case "3": Cor[Posicao] = Console.ReadLine();
                            break;
                        case "4": Quilometragem[Posicao] = Console.ReadLine();
                            break;
                        case "5": Situacao[Posicao] = Console.ReadLine();
                            break;
                        case "6": Disponibilidade[Posicao] = Console.ReadLine();
                            break;
                        case "7": ValorDiaria[Posicao] = Console.ReadLine();
                            break;
                        default: Console.WriteLine("Opção incorreta! Digite novamente!");
                            continue;
                    }
                } while (Opcao != "8");
            }
        }       
    }
}
