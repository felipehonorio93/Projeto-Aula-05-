using ProjetoAula05.Entities;
using ProjetoAula05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoAula05.Repositories
{
    /// <summary>
    /// Classe para salvar os dados de pedido em arquivo XML
    /// </summary>
    public class PedidoRepositoryXML : IPedidoRepository
    {
        public void Salvar(List<Pedido> pedidos)
        {
            //Serializando os dados para XML
            var xml = new XmlSerializer(pedidos.GetType());
            //abrindo um arquivo e gravando os dados
            using (var streamWriter
           = new StreamWriter("C:\\temp\\pedidos.xml"))
            {
                xml.Serialize(streamWriter, pedidos);
            }
        }
    }
}