using ProjetoAula05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Interfaces
{
    /// <summary>
    /// Interface para abstração de métodos de repositório para Pedido
    /// </summary>
    public interface IPedidoRepository
    {
        void Salvar(List<Pedido> pedidos);
    }
}