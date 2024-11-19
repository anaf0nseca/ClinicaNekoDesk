using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Cliente
    {

        public int Id { get; set; }
        public string? Nome { get; set; }    
        public string Cpf   { get; set; }
        public DateTime? Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string? Senha { get; set; }

        public Cliente()
        {

        }

        public Cliente(string? nome, string cpf, DateTime? data_Nascimento, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Data_Nascimento = data_Nascimento;
            Email = email;
        }

        public Cliente(int id, string? nome, DateTime? data_Nascimento, string email)
        {
            Id = id;
            Nome = nome;
            Data_Nascimento = data_Nascimento;
            Email = email;
        }

        public Cliente(string? nome, string cpf, DateTime? data_Nascimento, string email, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Data_Nascimento = data_Nascimento;
            Email = email;
            Senha = senha;
        }


        public Cliente(int id, string? nome, string cpf, DateTime? data_Nascimento, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Data_Nascimento = data_Nascimento;
            Email = email;
        }

        public Cliente(int id, string? nome, DateTime? data_Nascimento, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Data_Nascimento = data_Nascimento;
            Email = email;
            Senha = senha;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nascimento", Data_Nascimento);
            cmd.Parameters.AddWithValue ("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);

            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                Id = dr.GetInt32(0);
            }

            cmd.Connection.Close();

        }

        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * from cliente where id = {id}";
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cliente = new(
                   dr.GetInt32(0),//id
                   dr.GetString(1),//nome
                   dr.GetString(2),//cpf
                   dr.GetDateTime(3),//data_Nasc
                   dr.GetString(4),//email
                   dr.GetString(5)//senha
                   );

            }
            cmd.Connection.Close();

            return cliente;
        }

        public static List<Cliente> ObterLista(string? nome = "")
        {
            List<Cliente> clientes = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if (nome == "")
            {
                comandosSQL.CommandText = "select * from cliente order by nome";
            }
            else
            {
                comandosSQL.CommandText = $"select * from cliente where nome like '%{nome}%' order by nome";
            }

            var dr = comandosSQL.ExecuteReader();
            while (dr.Read())
            {
                clientes.Add(new(
                   dr.GetInt32(0),//id
                   dr.GetString(1),//nome
                   dr.GetString(2),//cpf
                   dr.GetDateTime(3),//data_Nasc
                   dr.GetString(4),//email
                   dr.GetString(5)//senha

                    )

               );
            }
            comandosSQL.Connection.Close();

            //clientes
            return clientes;

        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spdata_nascimento", Data_Nascimento);
            cmd.Parameters.AddWithValue("spemail", Email);


            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


    }
}
