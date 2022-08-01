using ProjetoAula05.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula05.Entities
{
    public class Pedido
    {
        #region Atributos

        private Guid _id;
        private DateTime _dataHora;
        private string _descricao;
        private decimal _valor;
        private StatusPedido _status;
        #endregion

        #region Propriedades
        public Guid Id
        {
            get => _id;
            set
            {
                if (value == Guid.Empty)
                    throw new ArgumentException
                   ("ID do pedido é obrigatório");

                _id = value;
            }
        }
        public DateTime DataHora
        {
            get => _dataHora;
            set
            {
                if (value == DateTime.MinValue)
                    throw new ArgumentException("Data/Hora é obrigatório.");
                _dataHora = value;
            }
        }
        public string Descricao
        {
            get => _descricao;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Descrição é obrigatória");
                _descricao = value;
            }
        }
        public decimal Valor
        {
            get => _valor;
            set
            {



                if (value <= 0)
                    throw new ArgumentException
                   ("O valor do pedido deve ser maior do que zero.");
                _valor = value;
            }
        }
        public StatusPedido Status
        {
            get => _status;
            set => _status = value;
        }
        #endregion
    }
}
