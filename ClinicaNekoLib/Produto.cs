using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Produto
    {
        public int Id { get; set; }
        public Categoria? Categoria { get; set; }
        public Marca? Marca { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime? Data_Validade { get; set; }
        public double Valor { get; set; }
        public double? Peso { get; set; }
        public int Qtde_Estoque { get; set; }

        public Produto(){}

        public Produto(Categoria? categoria, Marca? marca, string? nome, string? descricao, DateTime? data_Validade, double valor, double? peso, int qtde_Estoque)
        {
            Categoria = categoria;
            Marca = marca;
            Nome = nome;
            Descricao = descricao;
            Data_Validade = data_Validade;
            Valor = valor;
            Peso = peso;
            Qtde_Estoque = qtde_Estoque;
        }

        public Produto(int id, Categoria? categoria, Marca? marca, string? nome, string? descricao, DateTime? data_Validade, double valor, double? peso, int qtde_Estoque)
            {
                Id = id;
                Categoria = categoria;
                Marca = marca;
                Nome = nome;
                Descricao = descricao;
                Data_Validade = data_Validade;
                Valor = valor;
                Peso = peso;
                Qtde_Estoque = qtde_Estoque;
            }


        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_insert";
            cmd.Parameters.AddWithValue("spid_categoria", Categoria.Id);
            cmd.Parameters.AddWithValue("spid_marca", Marca.Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spdata_validade", Data_Validade);
            cmd.Parameters.AddWithValue("spvalor", Valor);
            cmd.Parameters.AddWithValue("sppeso", Peso);
            cmd.Parameters.AddWithValue("spqtde_estoque", Qtde_Estoque);

            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();

        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spid_categoria", Categoria.Id);
            cmd.Parameters.AddWithValue("spid_marca", Marca.Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spdescricao", Descricao);
            cmd.Parameters.AddWithValue("spdata_validade", Data_Validade);
            cmd.Parameters.AddWithValue("spvalor", Valor);
            cmd.Parameters.AddWithValue("sppeso", Peso);
            cmd.Parameters.AddWithValue("spqtde_estoque", Qtde_Estoque);

            cmd.ExecuteNonQuery();

            cmd.Connection.Close();

        }

        public static Produto ObterPorId(int id)
        {
            //método construtor vazio, 
            Produto produto = new Produto();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from produto where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                dr.GetInt32(0),
                Categoria.ObterPorId(dr.GetInt32(1)),
                Marca.ObterPorId(dr.GetInt32(2)),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetDateTime(5),
                dr.GetDouble(6),
                dr.GetDouble(7),
                dr.GetInt32(8)
                    );
            }
            cmd.Connection.Close();

            return produto;
        }


        public static List<Produto> ObterLista()
        {
            //método construtor vazio, 
            List<Produto> produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produto order by nome";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(
                dr.GetInt32(0),
                Categoria.ObterPorId(dr.GetInt32(1)),
                Marca.ObterPorId(dr.GetInt32(2)),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetDateTime(5),
                dr.GetDouble(6),
                dr.GetDouble(7),
                dr.GetInt32(8)

                ));
            }

            cmd.Connection.Close();
            return produtos;
        }

        public static List<Produto> ObterListaPorCategoria(int categoriaId)
        {
            List<Produto> produtos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from produto where id_categoria = {categoriaId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produtos.Add(new(
                dr.GetInt32(0),
                Categoria.ObterPorId(dr.GetInt32(1)),
                Marca.ObterPorId(dr.GetInt32(2)),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetDateTime(5),
                dr.GetDouble(6),
                dr.GetDouble(7),
                dr.GetInt32(8)

                ));
            }

            cmd.Connection.Close();
            return produtos;
        }



    }
}
