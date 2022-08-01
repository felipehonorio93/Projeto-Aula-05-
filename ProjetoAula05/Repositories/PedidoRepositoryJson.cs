using Newtonsoft.Json;
using ProjetoAula05.Entities;
using ProjetoAula05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Repositories
{
    /// <summary>
    /// Classe para salvar os dados de pedido em arquivo JSON
    /// </summary>
    public class PedidoRepositoryJSON : IPedidoRepository
    {
        public void Salvar(List<Pedido> pedidos)
        {
            //Serializando os dados para o formato JSON
            var json = JsonConvert.SerializeObject
           (pedidos, Formatting.Indented);
            //gravando o arquivo
            using (var streamWriter = new StreamWriter
           ("C:\\temp\\pedidos.json"))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}
