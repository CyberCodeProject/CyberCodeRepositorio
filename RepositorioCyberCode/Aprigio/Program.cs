using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprigio
{
    class Program
    {
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
    }
}
