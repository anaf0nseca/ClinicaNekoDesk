using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        public decimal Valor { get; set; }
        public double? Peso { get; set; }
        public int Qtde_Estoque { get; set; }

        public string? Imagem { get; set; }

        public Produto(){}

        public Produto(Categoria? categoria, Marca? marca, string? nome, string? descricao, DateTime? data_Validade, decimal valor, double? peso, int qtde_Estoque, string? imagem)
        {
            Categoria = categoria;
            Marca = marca;
            Nome = nome;
            Descricao = descricao;
            Data_Validade = data_Validade;
            Valor = valor;
            Peso = peso;
            Qtde_Estoque = qtde_Estoque;
            Imagem = imagem;
        }

        public Produto(int id, Categoria? categoria, Marca? marca, string? nome, string? descricao, DateTime? data_Validade, decimal valor, double? peso, int qtde_Estoque, string? imagem)
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
                Imagem = imagem;

        }

        public Produto(int id, Categoria? categoria, Marca? marca, string? nome, string? descricao, DateTime? data_Validade, decimal valor)
        {
            Id = id;
            Categoria = categoria;
            Marca = marca;
            Nome = nome;
            Descricao = descricao;
            Data_Validade = data_Validade;
            Valor = valor;
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
                dr.GetDecimal(6),
                dr.GetDouble(7),
                dr.GetInt32(8),
                null
                    );
            }
            cmd.Connection.Close();

            return produto;
        }


        public static List<Produto> ObterLista()
        {
            ////método construtor vazio, 
            //List<Produto> produtos = new List<Produto>();
            //var cmd = Banco.Abrir();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from produto order by nome";
            //var dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    produtos.Add(new(
            //    dr.GetInt32(0),
            //    Categoria.ObterPorId(dr.GetInt32(1)),
            //    Marca.ObterPorId(dr.GetInt32(2)),
            //    dr.GetString(3),
            //    dr.GetString(4),
            //    dr.GetDateTime(5),
            //    dr.GetDecimal(6),
            //    dr.GetDouble(7),
            //    dr.GetInt32(8), 
            //    null

            //    ));
            //}

            // Lista de produtos
            List<Produto> produtos = new();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produto order by nome";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                // Verificando valores nulos antes de obter os dados
                int categoriaId = dr.IsDBNull(1) ? 0 : dr.GetInt32(1);
                int marcaId = dr.IsDBNull(2) ? 0 : dr.GetInt32(2);
                string nome = dr.IsDBNull(3) ? string.Empty : dr.GetString(3);
                string descricao = dr.IsDBNull(4) ? string.Empty : dr.GetString(4);
                DateTime dataCadastro = dr.IsDBNull(5) ? DateTime.MinValue : dr.GetDateTime(5);
                decimal preco = dr.IsDBNull(6) ? 0m : dr.GetDecimal(6);
                double peso = dr.IsDBNull(7) ? 0.0 : dr.GetDouble(7);
                int estoque = dr.IsDBNull(8) ? 0 : dr.GetInt32(8);

                // Criando o objeto Produto corretamente
                produtos.Add(new Produto(
                    dr.GetInt32(0), // Id do produto
                    Categoria.ObterPorId(categoriaId), // Obter categoria com base no ID
                    Marca.ObterPorId(marcaId), // Obter marca com base no ID
                    nome, // Nome do produto
                    descricao, // Descrição do produto
                    dataCadastro, // Data de cadastro do produto
                    preco, // Preço do produto
                    peso, // Peso do produto
                    estoque, // Estoque do produto
                    null // Último parâmetro (caso não tenha valor para ele)
                ));
            }

            // Fechar a conexão
            cmd.Connection.Close();
            //cmd.Connection.Close();
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
                dr.GetDecimal(6),
                dr.GetDouble(7),
                dr.GetInt32(8),
                null

                ));
            }

            cmd.Connection.Close();
            return produtos;
        }

        public void Excluir()
        {
            // em geral nada se exclui de uma tabela...
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from produto where id = {Id}";
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();


        }



    }
}
