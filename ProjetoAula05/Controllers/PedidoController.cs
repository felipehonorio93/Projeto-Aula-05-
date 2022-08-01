using ProjetoAula05.Entities;
using ProjetoAula05.Enums;
using ProjetoAula05.Helpers;
using ProjetoAula05.Interfaces;
using ProjetoAula05.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Controllers
{
    /// <summary>
    /// Classe de controle de pedidos
    /// </summary>
    public class PedidoController
    {
        public void CadastrarPedidos()
        {
            try
            {
                Console.WriteLine("\n *** CADASTRO DE PEDIDOS *** \n");
                //declarando uma lista de pedidos (vazia)
                var pedidos = new List<Pedido>();
                var qtd = int.Parse(InputHelper.Get("Entre com a quantidade de pedidos: "));
                for (int i = 1; i <= qtd; i++)
                {
                    Console.WriteLine($"\nEntre com o {i}º Pedido:\n");
                    //criando uma variável de instância
                    //para a entidade pedido
                    var pedido = new Pedido();
                    pedido.Id = Guid.NewGuid();
                    pedido.DataHora = DateTime.Parse(InputHelper.Get
                   ("Data/Hora do pedido....: "));
                    pedido.Descricao = InputHelper.Get
                   ("Descrição do pedido....: ");
                    pedido.Valor = decimal.Parse(InputHelper.Get
                   ("Valor do pedido........: "));
                    pedido.Status = (StatusPedido)int.Parse(InputHelper.Get
                   ("Status (1,2 ou 3)......: "));
                    pedidos.Add(pedido); //adicionando o pedido na lista
                }

                var opcao = InputHelper.Get("\nDeseja salvar em JSON ou XML?...: ");
                IPedidoRepository pedidoRepository; //Interface!

                switch (opcao.ToLower())
                {
                    case "xml":
                        pedidoRepository = new PedidoRepositoryXML(); //POLIMORFISMO
                        break;
                    case "json":
                        pedidoRepository = new PedidoRepositoryJSON(); //POLIMORFISMO
                        break;
                    default:
                        throw new ArgumentException("Opção inválida.");
                }

                pedidoRepository.Salvar(pedidos);

                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
            }


            catch (ArgumentException e)
            {
                Console.WriteLine($"\nErro de validação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha: {e.Message}");
            }
        }
    }
}