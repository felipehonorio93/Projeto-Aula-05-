using ProjetoAula05.Controllers;

namespace ProjetoAula05
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pedidoController = new PedidoController();
            pedidoController.CadastrarPedidos();
            Console.ReadKey();
        }
    }
}