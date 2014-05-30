﻿using System;
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
        static double RendaMensal =0;
        static double RendaCaixa =0;
        static int PosicaoCliente=0;
        static string[] Usuarios = {"aprigio","luis","mateus","greicy","thiago"};
        static int garagem = 0;
        static int rodando = 0;
        static int reservado = 0;

        static string[] Marca = new string[constante];
        static string[] Placa = new string[constante];
        static string[] Cor = new string[constante];
        static double[] Quilometragem = new double[constante];
        static string[] Situacao = new string[constante];
        static int[] DiasLocado = new int[constante];
        static double[] ValorDiaria = new double[constante];

        static string[] Nome = new string[constante];
        static double[] Saldo = new double[constante];
        static string [] Carro = new string[constante];
        static string[] RG = new string[constante];
        static string[] CPF = new string[constante];
        static string[,] Endereco = new string[7, constante];
        //Endereço: Linha 1 = Pais; Linha 2= Estado; Linha 3 =Cidade; Linha 4= Rua; Linha 5 = Bairro; Linha 6 = Numero; Linha 7 = Complemento

        static void Main(string[] args)
        {


        }
        static void Reserva()
        {
            do
            {
                int data = 0;
                Opcao = null;
                Posicao = 0;
                ConsultaCliente();
                Console.Clear();
                if (Posicao != 0)
                {
                    Console.WriteLine("Nome.........: {0}", Nome[Posicao]);
                    Console.WriteLine("RG...........: {0}", RG[Posicao]);
                    Console.WriteLine("CPF..........: {0}", CPF[Posicao]);
                    Console.WriteLine("Saldo........: {0}", Saldo[Posicao]);
                    PosicaoCliente = Posicao;
                    if (Saldo[Posicao] > 0)
                    {
                        do
                        {
                            Console.WriteLine("Cliente devendo um saldo de {0}, deseja efetuar o pagamento ?   (S/N) ", Saldo[Posicao]);
                            Opcao = Console.ReadLine();
                            Opcao = Opcao.ToLower();
                        } while (Opcao != "n" || Opcao != "s");
                        if (Opcao == "s")
                        {
                            Saldo[Posicao] = 0;
                            RendaMensal += Saldo[Posicao];
                            RendaCaixa += Saldo[Posicao];
                            Console.WriteLine("Voce paga suas dividas bom homem, iremos reiniciar a nossa consulta.");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Pesquisando carro ...");
                            Console.ReadKey();
                            ConsultaCarros();
                            Console.Clear();
                            Console.WriteLine("\nMarca............: {0}", Marca[Posicao]);
                            Console.WriteLine("Placa............: {0}", Placa[Posicao]);
                            Console.WriteLine("Cor..............: {0}", Cor[Posicao]);
                            Console.WriteLine("Km Atual.........: {0}", Quilometragem[Posicao]);
                            Console.WriteLine("Valor Diária.....: {0}", ValorDiaria[Posicao]);
                            do
                            {
                                if (DiasLocado[Posicao] > 0)
                                {
                                    Console.WriteLine("A locação ficará para daqui a {0} dias.", DiasLocado[Posicao] + 1);
                                    Console.WriteLine("(S/N)");
                                    Opcao = Console.ReadLine();
                                    Opcao = Opcao.ToLower();
                                    if (Opcao == "n")
                                    {
                                        Console.WriteLine("Fica pra próxima então, o carro está {0}.", Situacao[Posicao]);
                                        Console.ReadKey();
                                        break;
                                    }
                                }
                                Console.WriteLine("\nDeseja locar o automovel por quantos dias ?");
                                data = int.Parse(Console.ReadLine());
                                if (data < 1 || data > 365)
                                {
                                    Console.WriteLine("Quantidade incorreta, insira novamente.");
                                    Console.ReadKey();
                                    continue;
                                }
                            } while (data < 1 || data > 365);
                            if (Opcao == "s")
                            {
                                Saldo[PosicaoCliente] = data * ValorDiaria[Posicao];
                                Situacao[Posicao] = "Reservado";
                                DiasLocado[Posicao] += data;
                                Carro[PosicaoCliente] = Placa[Posicao];
                                reservado += 1;
                            }
                        } while (Opcao != "n" || Opcao != "s");
                    }
                }
                Opcao = null;
                Console.Write("\n\nDeseja tentar outra reserva ?     (S/N) ");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
            }while (Opcao != "s");
        } 
        static void Locacao()

        {

            do{
                int dia =0;
                Opcao = null;
                Posicao = 0;
                ConsultaCliente();
                Console.Clear();
                if (Posicao != 0 )
                {
                    Console.WriteLine("Nome.........: {0}", Nome[Posicao]);
                    Console.WriteLine("RG...........: {0}", RG[Posicao]);
                    Console.WriteLine("CPF..........: {0}", CPF[Posicao]);
                    Console.WriteLine("Saldo........: {0}", Saldo[Posicao]);
                    PosicaoCliente = Posicao;
                    if (Saldo[Posicao] > 0)
                    {
                        do{
                            Console.WriteLine("Cliente devendo um saldo de {0}, deseja efetuar o pagamento ?   (S/N) ",Saldo[Posicao]);
                            Opcao = Console.ReadLine();
                            Opcao = Opcao.ToLower();
                        } while (Opcao != "n" || Opcao != "s");
                        if (Opcao == "s"){
                            Saldo[Posicao]=0;
                            RendaMensal += Saldo[Posicao];
                            RendaCaixa += Saldo[Posicao];
                            continue;
                        }
                    }else{
                        do{
                            Console.WriteLine("Pesquisando carro ...");
                            Console.ReadKey();
                            ConsultaCarros();
                            Console.Clear();
                            if(DiasLocado[Posicao] == 0 && Situacao[Posicao] == "Garagem")
                            {
                                Console.WriteLine("\nMarca............: {0}", Marca[Posicao]);
                                Console.WriteLine("Placa............: {0}", Placa[Posicao]);
                                Console.WriteLine("Cor..............: {0}", Cor[Posicao]);
                                Console.WriteLine("Km Atual.........: {0}", Quilometragem[Posicao]);
                                Console.WriteLine("Valor Diária.....: {0}", ValorDiaria[Posicao]);
                                do{
                                    Console.WriteLine("\nDeseja locar o automovel por quantos dias ?");
                                    dia = int.Parse(Console.ReadLine());
                                    if (dia<1 || dia> 365){
                                        Console.WriteLine("Quantidade incorreta, insira novamente.");
                                        Console.ReadKey();
                                        continue;
                                    }
                                }while(dia<1 || dia> 365);
                                
                                Saldo[PosicaoCliente] = dia * ValorDiaria[Posicao];
                                Situacao[Posicao] = "Rodando";
                                DiasLocado[Posicao] = dia;
                                Carro[PosicaoCliente] = Placa[Posicao];
                                rodando += 1;
                                garagem -= 1;
                            }
                            else{
                                    Console.WriteLine("Carro indisponível. {0}",Situacao[Posicao]);
                                    Console.Write("\n\nDeseja tentar outra locação ?     (S/N) ");
                                    Opcao = Console.ReadLine();
                                    Opcao = Opcao.ToLower();
                            }
                        }while (Opcao != "n");
                    }
                }
            }while(Opcao != "n");
        } 
        static void Devolucao()
        {
            do{
                double km =0;
                int dia =0;
                Opcao = null;
                Posicao = 0;
                ConsultaCliente();
                Console.Clear();
                if (Posicao != 0 )
                {
                    Console.WriteLine("Nome............: {0}", Nome[Posicao]);
                    Console.WriteLine("RG..............: {0}", RG[Posicao]);
                    Console.WriteLine("CPF.............: {0}", CPF[Posicao]);
                    Console.WriteLine("Saldo...........: {0}", Saldo[Posicao]);
                    Console.WriteLine("Placa do carro...:{0}",Carro[Posicao]);
                    PosicaoCliente = Posicao;
                    for(int i=0; i< CarroCadastrado;i++){
                        if (Carro[PosicaoCliente] == Placa[i]){
                            Console.WriteLine("Marca....................: {0}", Marca[i]);
                            Console.WriteLine("Placa....................: {0}", Placa[i]);
                            Console.WriteLine("Cor......................: {0}", Cor[i]);
                            Console.WriteLine("Quilometragem Inicial....: {0}",Quilometragem[i]);
                        }
                    }                    
                    do{
                        Console.WriteLine("Quilometragem da volta : ");
                        km = double.Parse(Console.ReadLine());
                        if(km < Quilometragem[Posicao]){
                            Console.WriteLine("Quilometragem errada, insira a correta.");
                            Console.ReadKey();
                            continue;
                        }else{
                            Quilometragem[Posicao] = km;
                        }
                    }while(km < Quilometragem[Posicao]);
                    do{
                            Console.WriteLine("Cliente devendo um saldo de {0}, deseja efetuar o pagamento ?   (S/N) ",Saldo[PosicaoCliente]);
                            Opcao = Console.ReadLine();
                            Opcao = Opcao.ToLower();
                    } while (Opcao != "n" || Opcao != "s");
                    if (Opcao == "s"){
                        Saldo[PosicaoCliente]=0;
                        RendaMensal += Saldo[Posicao];
                        RendaCaixa += Saldo[Posicao];
                        garagem += 1;
                        rodando -= 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Voce precisa pagar, obtenha dinheiro !!");
                        Console.ReadKey();
                        continue;
                    }
                }
            }while(Opcao == "s");
        }
        static void CadastroCarro()
        {
            do
            {
                Opcao = null;
                Console.Clear();
                Console.WriteLine("\t\tCadastrando um novo Carro \n\n");
                Console.Write("Marca: ");
                Marca[CarroCadastrado - CarrosRemovidos] = Console.ReadLine();
                do
                {
                    Console.Write("Placa: \t(XXX000)");
                    Placa[CarroCadastrado - CarrosRemovidos] = Console.ReadLine();
                } while (Placa[CarroCadastrado - CarrosRemovidos].Length != 6);
                Console.Write("Cor: ");
                Cor[CarroCadastrado - CarrosRemovidos] = Console.ReadLine();
                Console.Write("Km Atual: ");
                Quilometragem[CarroCadastrado - CarrosRemovidos] = double.Parse(Console.ReadLine());
                Situacao[CarroCadastrado - CarrosRemovidos] = "Garagem";
                DiasLocado[CarroCadastrado - CarrosRemovidos] = 0;
                Console.WriteLine("Qual o valor da diária deste carro ?");
                ValorDiaria[CarroCadastrado - CarrosRemovidos] = double.Parse(Console.ReadLine());
                garagem += 1;
                CarroCadastrado += 1;
                Console.Write("\n\nDeseja cadastrar outro automóvel ?     (S/N) ");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }
        static void CadastroCliente()
        {
            do
            {
                Console.Clear();
                Opcao = null;
                Console.WriteLine("\t\t\t CADASTRO CLIENTE :\n\n");
                Console.Write("Nome : ");
                Nome[ClienteCadastrado - ClientesRemovidos] = Console.ReadLine();
                do
                {
                    Console.Write("RG : (10 digitos)");
                    RG[ClienteCadastrado - ClientesRemovidos] = Console.ReadLine();
                } while (RG[ClienteCadastrado - ClientesRemovidos].Length != 10);
                do
                {
                    Console.Write("CPF : (11 digitos)");
                    CPF[ClienteCadastrado - ClientesRemovidos] = Console.ReadLine();
                } while (CPF[ClienteCadastrado - ClientesRemovidos].Length != 11);
                Console.Write("Pais : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 0] = Console.ReadLine();
                Console.Write("Estado : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 1] = Console.ReadLine();
                Console.Write("Cidade : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 2] = Console.ReadLine();
                Console.Write("Rua : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 3] = Console.ReadLine();
                Console.Write("Bairro : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 4] = Console.ReadLine();
                Console.Write("Numero : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 5] = Console.ReadLine();
                Console.Write("Complemento : ");
                Endereco[ClienteCadastrado - ClientesRemovidos, 6] = Console.ReadLine();
                Saldo[ClienteCadastrado - ClientesRemovidos] = 0;
                ClienteCadastrado += 1;
                Console.Write("\n\nDeseja cadastrar outro cliente ?     (S/N) ");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "n");
        }
        static void ConsultaCliente()
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
                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t CONSULTA DE CARRO :\n\n");
                    Console.Write("Digite a placa do carro : ");
                    Pesquisa = Console.ReadLine();
                    if (Pesquisa.Length != 6)
                    {
                        Console.WriteLine("Placa invalida, digite no formato correto da mesma (6 digitos, 3 letras e 3 numeros).");
                        continue;
                    }
                } while (Pesquisa.Length != 6);
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos; i++)
                {
                    if (Pesquisa == Placa[i])
                    {
                        Console.WriteLine("\tMarca............: {0}", Marca[i]);
                        Console.WriteLine("\tPlaca............: {0}", Placa[i]);
                        Console.WriteLine("\tCor..............: {0}", Cor[i]);
                        Console.WriteLine("\tKm Atual.........: {0}", Quilometragem[i]);
                        Console.WriteLine("\tSituação.........: {0}", Situacao[i]);
                        Console.WriteLine("\tDisponibilidade..: {0} dias", DiasLocado[i]);
                        Console.WriteLine("\tValor Diária.....: {0}", ValorDiaria[i]);
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
        static void TabelaPrecoCarros()
        {
            do
            {
                Opcao = null;
                Console.Clear();
                Console.WriteLine("\t\t\t TABELA DE PREÇOS \n\n");
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Placa............: {0}", Placa[i]);
                    Console.WriteLine("Cor..............: {0}", Cor[i]);
                    Console.WriteLine("Valor Diária.....: {0}", ValorDiaria[i]);
                }
                Console.WriteLine("\n\nDeseja sair da tabela ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "s");
        }
        static void SituacaoDosCarros()
        {
            Console.WriteLine("\t\t\t SITUAÇÃO DOS CARROS \n\n");
            do
            {
                Opcao = null;
                Console.Clear();
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos ; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Marca............: {0}", Marca[i]);
                    Console.WriteLine("Local............: {0}", Situacao[i]);
                    Console.WriteLine("Disponivel em....: {0} dias", DiasLocado[i] + 1);
                }
                Console.WriteLine("\n\nDeseja sair ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();

            } while (Opcao != "s");
        }
        static void RelatorioCliente()
        {
            Console.WriteLine("\t\t\t RELATORIO SOBRE CLIENTES :\n\n");
            do
            {
                Opcao = null;
                Console.Clear();
                for (int i = 0; i < ClienteCadastrado; i++)
                {
                    Console.WriteLine("\nNome.........: {0}", Nome[i]);
                    Console.WriteLine("RG...........: {0}", RG[i]);
                    Console.WriteLine("CPF..........: {0}", CPF[i]);
                    Console.WriteLine("Pais.........: {0}", Endereco[i, 0]);
                    Console.WriteLine("Estado.......: {0}", Endereco[i, 1]);
                    Console.WriteLine("Cidade.......: {0}", Endereco[i, 2]);
                    Console.WriteLine("Rua..........: {0}", Endereco[i, 3]);
                    Console.WriteLine("Bairro.......: {0}", Endereco[i, 4]);
                    Console.WriteLine("Numero.......: {0}", Endereco[i, 5]);
                    Console.WriteLine("Complemento..: {0}", Endereco[i, 6]);
                    Console.WriteLine("Saldo........: {0}", Saldo[i]);
                }
                Console.WriteLine("\n\nDeseja sair da consulta ?      (S/N)");
                Opcao = Console.ReadLine();
                Opcao = Opcao.ToLower();
            } while (Opcao != "s");
        }
        static void RelatorioCarro()
        {
            Console.WriteLine("\t\t\t RELATORIO SOBRE CARROS :\n\n");
            do
            {
                Opcao = null;
                Console.Clear();
                for (int i = 0; i < CarroCadastrado - CarrosRemovidos; i++)
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
        static void RelatorioCaixa()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t RELATORIO DO CAIXA  \n   ");
            Console.WriteLine("\nTemos {0} carros na garagem.",garagem);
            Console.WriteLine("Temos {0} carros rodando.",rodando);
            Console.WriteLine("Temos {0} carros reservados.",reservado);
            Console.WriteLine("Dinheiro em caixa : {0} R$",RendaCaixa);
            Console.ReadKey();
        }
        static void RelatorioMes()
        {
            double dinheiroFaltando = 0;
            Console.Clear();
            Console.WriteLine("\t\t\t RELATORIO MENSAL  \n   ");
            Console.WriteLine("\nClientes : {0}", ClienteCadastrado - ClientesRemovidos);
            Console.WriteLine("Carros : {0}", CarroCadastrado - CarrosRemovidos);
            Console.WriteLine("Temos {0} carros na garagem.", garagem);
            Console.WriteLine("Temos {0} carros rodando.", rodando);
            Console.WriteLine("Temos {0} carros reservados.", reservado);
            for (int i = 0; i < ClienteCadastrado - ClientesRemovidos; i++)
            {
                if (Saldo[i] > 0)
                {
                    dinheiroFaltando += Saldo[i];
                }
            }
            Console.WriteLine("Dinheiro : {0} R$", RendaMensal);
            Console.WriteLine("A receber : {0} R$", dinheiroFaltando);
            Console.WriteLine("Total = {0} R$", RendaMensal + dinheiroFaltando);
            Console.ReadKey();

        }
        static void RemoverCarro()
        {
            int remover = 0;
            ConsultaCarros();
            if (Achou == 1)
            {
                Console.WriteLine("Tem certeza que deseja remover este carro?");
                do
                {
                    Console.WriteLine("S/N)");
                    Resposta = Console.ReadLine();
                    Resposta = Resposta.ToUpper();
                    if (Resposta != "S" && Resposta != "N")
                    {
                        Console.WriteLine("Resposta incorreta, digite novamente! ");
                    }
                } while (Resposta != "S" && Resposta != "N");
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
                            if (Usuarios[i] + "123" == SenhaTeste)
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
                                remover = 1;
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

                    } while (Tentativas != 0 || remover != 1);
                }
            }
        }
        static void RemoverCliente()
        {
            int remover = 0;
            ConsultaCliente();
            Console.Clear();
            if (Achou == 1)
            {
                Console.WriteLine("Tem certeza que deseja remover este cliente?");
                do
                {
                    Console.WriteLine("(S/N)");
                    Resposta = Console.ReadLine();
                    Resposta = Resposta.ToUpper();
                    if (Resposta != "S" && Resposta != "N")
                    {
                        Console.WriteLine("Resposta incorreta, digite novamente! ");
                    }
                } while (Resposta != "S" && Resposta != "N");
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
                            if (Usuarios[i] + "123" == SenhaTeste)
                            {
                                for (int j = Posicao; j < ClienteCadastrado; j++)
                                {
                                    Nome[i] = Nome[i + 1];
                                    RG[i] = RG[i + 1];
                                    CPF[i] = CPF[i + 1];
                                    for (int e = 0; j < 7; j++)
                                    {
                                        Endereco[i, e] = Endereco[i + 1, e];
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
            ConsultaCliente();
            if (Achou == 1)
            {
                do
                {
                    Console.Clear();
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
                        case "10": Endereco[Posicao, 6] = Console.ReadLine();
                            break;
                        case "11": Saldo[Posicao] = double.Parse(Console.ReadLine());
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
                        case "1": Marca[Posicao] = Console.ReadLine();
                            break;
                        case "2":
                            do
                            {
                                Console.WriteLine("(XXX-000): ");
                                Placa[Posicao] = Console.ReadLine();
                                if (Placa[Posicao].Length != 6)
                                {
                                    Console.WriteLine("Placa invalida. Digite novamente com 6 digitos!");
                                }
                            } while (Placa[Posicao].Length != 6);
                            break;
                        case "3": Cor[Posicao] = Console.ReadLine();
                            break;
                        case "4": Quilometragem[Posicao] = double.Parse(Console.ReadLine());
                            break;
                        case "5": Console.WriteLine("(Garagem - Rodando - Reservado): ");
                            Situacao[Posicao] = Console.ReadLine();
                            break;
                        case "6": DiasLocado[Posicao] = int.Parse(Console.ReadLine());
                            break;
                        case "7": ValorDiaria[Posicao] = double.Parse(Console.ReadLine());
                            break;
                        default: Console.WriteLine("Opção incorreta! Digite novamente!");
                            continue;
                    }
                } while (Opcao != "8");
            }
        }       



    }
}
