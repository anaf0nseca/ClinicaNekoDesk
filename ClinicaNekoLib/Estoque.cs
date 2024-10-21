using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Estoque
    {
        public Produto Produto { get; set; }
        public double? Quantidade { get; set; }
        public DateTime? Data_Ultimo_Movimento { get; set; }

        public Estoque() { }

        public Estoque(Produto produto, double? quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public Estoque(Produto produto, double? quantidade, DateTime? data_Ultimo_Movimento)
        {
            Produto = produto;
            Quantidade = quantidade;
            Data_Ultimo_Movimento = data_Ultimo_Movimento;
        }

        //public void Inserir();

        public void Atualizar(int idProduto, double Quantidade)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update estoque set quantidade = {Quantidade} where id_produto = {idProduto}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static Estoque ObterPorProduto(int idProduto)
        {
            Estoque estoque = new Estoque();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * from estoque where id_produto = {idProduto}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                estoque = new(
                    Produto.ObterPorId(dr.GetInt32(0)),
                    dr.GetDouble(1),
                    dr.GetDateTime(2)
                    );
            }

            return estoque;
        }

    }
}
