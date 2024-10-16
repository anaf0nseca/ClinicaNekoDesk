using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime? Data { get; set; }
        public string Status { get; set; }
        public double? Desconto { get; set; }

        public Pedido() { }

        public Pedido(Usuario usuario, Cliente cliente, DateTime? data, string status, double? desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }


        public Pedido(int id, Usuario usuario, Cliente cliente, DateTime? data, string status, double? desconto)
        {
            Id = id;
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
            Desconto = desconto;
        }


        
    }
}
