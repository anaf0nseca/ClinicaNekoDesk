using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
        //public List<ItemPedido> Itens { get; set; }

        public Pedido() { }


        public Pedido (Usuario usuario, Cliente cliente)
        {
            Usuario = usuario;
            Cliente = cliente;

        }


        public Pedido(Usuario usuario, Cliente cliente, double desconto)
        {
            Usuario = usuario;
            Cliente = cliente;
            Desconto = desconto;

        }
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


        public void Inserir()
        {

        }

        public void AlterarStatus(int Id, string Status)
        {

        }

        public void AtualizarDesconto(int Id, double Desconto)
        {

        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new Pedido();

            return pedido;
        }

        public static List<Pedido> ObterLista(int id = 0)
        {
            List<Pedido> pedidos = new();

            return pedidos;
        }

        public static List<Pedido> ObterListaPorCliente(int idCliente)
        {
            List<Pedido> pedidosCliente = new();


            return pedidosCliente;
        }

        public static List<Pedido> ObterListaPorUsuario(int idUsuario)
        {
            List<Pedido> pedidosUsuario = new();


            return pedidosUsuario;
        }
    }
}
