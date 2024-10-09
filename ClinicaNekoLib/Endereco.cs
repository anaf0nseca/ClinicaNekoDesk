using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Endereco
    {

        public int Id { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }

        public string? Uf { get; set; }
        public string? TipoEndereco { get; set; }

        public Endereco() { }

        public Endereco(string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade,  string? uf, string? tipoEndereco)
        {
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public Endereco(int id, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade,  string? uf, string? tipoEndereco)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            TipoEndereco = tipoEndereco;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

        }

        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new Endereco();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from endereco where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                endereco = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                    );
            }
            return endereco;
        }

        public static List<Endereco> ObterLista()
        {
            List<Endereco> enderecos = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;

            comandosSQL.CommandText = $"select * from enderecos order by nome";


            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8)
                        )
                    );
            }
            return enderecos;
        }

        public void Atualizar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";

            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("sptipo_endereco", TipoEndereco);

            //Quando uma procedure é executada, 0 nenhuma alteração, 1 alterado e -1 falha
            //return cmd.ExecuteNonQuery()>-1?true:false

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}
