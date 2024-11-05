using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Pagamento
    {

        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public double Valor { get; set; }

        public Pagamento() { }

        public Pagamento(Pedido pedido, FormaPagamento formaPagamento, double valor)
        {
            Pedido = pedido;
            FormaPagamento = formaPagamento;
            Valor = valor;
        }
        public Pagamento(int id, Pedido pedido, FormaPagamento formaPagamento, double valor)
        {
            Id = id;
            Pedido = pedido;
            FormaPagamento = formaPagamento;
            Valor = valor;
        }


    }
}
