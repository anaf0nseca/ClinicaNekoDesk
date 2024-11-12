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

        public Pedido(Usuario usuario, Cliente cliente, DateTime? data, string status)
        {
            Usuario = usuario;
            Cliente = cliente;
            Data = data;
            Status = status;
        }

        public Pedido(int id, double? desconto)
        {
            Id = id;
            Desconto = desconto;

        }

        public Pedido(int id, string status)
        {
            Id = id;
            Status = status;

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
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_insert";
            cmd.Parameters.AddWithValue("spid_usuario", Usuario.Id);
            cmd.Parameters.AddWithValue("spid_cliente", Cliente.Id);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public void AlterarStatus(int Id, string Status)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedido set status = '{Status} where id = {Id}'";
            
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void AtualizarDesconto(int Id, double Desconto)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update pedido set desconto = '{Desconto}' where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Pedido ObterPorId(int id)
        {
            Pedido pedido = new Pedido();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text ;
            cmd.CommandText = $"select * from pedido where id = {id}";
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                pedido = new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)

                    );
            }

            return pedido;
        }

        public static List<Pedido> ObterLista(int id = 0)
        {
            List<Pedido> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "select * from pedido order by data";


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)


                    ));
            }

            cmd.Connection.Close();
            return pedidos;

        }

        public static List<Pedido> ObterListaPorCliente(int idCliente)
        {
            List<Pedido> pedidosCliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedido where cliente_id = {idCliente}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidosCliente.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)

                    ));
            }

            cmd.Connection.Close();
            return pedidosCliente;
        }

        public static List<Pedido> ObterListaPorUsuario(int idUsuario)
        {
            List<Pedido> pedidosUsuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pedido where usuario_id = {idUsuario}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidosUsuario.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Cliente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetString(4),
                    dr.GetDouble(5)

                    ));
            }
            cmd.Connection.Close();

            return pedidosUsuario;
        }
    }
}
