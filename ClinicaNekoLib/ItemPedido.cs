using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public Produto Produto { get; set; }
        public decimal Valor { get; set; }  
        public int Quantidade { get; set; }
        public decimal Desconto { get; set; }

        public ItemPedido() { }
        public ItemPedido(int id, int idPedido, Produto produto, decimal valor, int quantidade, decimal desconto)
        {
            Id = id;
            IdPedido = idPedido;
            Produto = produto;
            Valor = valor;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(int idPedido, Produto produto, decimal valor, int quantidade, decimal desconto)
        {
            IdPedido = idPedido;
            Produto = produto;
            Valor = valor;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("spid_pedido", IdPedido);
            cmd.Parameters.AddWithValue("spid_produto", Produto.Id);
            //subconsulta (select valor_unit from produtos where id = spproduto_id) = Busca e insere na tabela ItemPedido o valor unitário já cadastrado anteriormente na tabela do produto
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);//desconto do item

            cmd.ExecuteNonQuery();
            // Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public static List<ItemPedido> ObterListaPorPedido(int idPedido)
        {
            List<ItemPedido> itens = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from item_pedido where id_pedido = {idPedido}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itens.Add(new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    Produto.ObterPorId(dr.GetInt32(2)),
                    dr.GetDecimal(3),
                    dr.GetInt32(4),
                    dr.GetDecimal(5)
                    ));
            }

            cmd.Connection.Close();
            return itens;
        }


        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
