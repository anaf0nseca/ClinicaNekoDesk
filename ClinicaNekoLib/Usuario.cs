using ClinicaNekoLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//API de Criptografia
//using Org.BouncyCastle.Crypto.Prng;

namespace ClinicaNekoLib
{
    public class Usuario
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
        public Setor Setor { get; set; }
        public Cargo Cargo { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public bool Ativo {  get; set; }


        public Usuario() 
        {
            Setor = new();
            Cargo = new();
        }

        public Usuario(string? nome, string? cpf, DateTime? dataNascimento, Setor setor, Cargo cargo, string email, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Setor = setor;
            Cargo = cargo;
            Email = email;
            Senha = senha;
        }


        public Usuario(int id, string? nome, DateTime? dataNascimento, Setor setor, Cargo cargo, string email)
        {
            Id = Id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Setor = setor;
            Cargo = cargo;
            Email = email;

        }
        public Usuario(string? nome, string? cpf, DateTime? dataNascimento, Setor setor, Cargo cargo, string email, string senha, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Setor = setor;
            Cargo = cargo;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id, string? nome, string? cpf, DateTime? dataNascimento, Setor setor, Cargo cargo, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Setor = setor;
            Cargo = cargo;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        public Usuario(int id, string? nome, string? cpf, DateTime? dataNascimento, Setor setor, Cargo cargo, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Setor = setor;
            Cargo = cargo;
            Senha = senha;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdata_nascimento", DataNascimento);
            cmd.Parameters.AddWithValue("spid_setor", Setor.Id);
            cmd.Parameters.AddWithValue("spid_cargo", Cargo.Id);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

            cmd.Connection.Close();
        }


        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuario where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),//id
                    dr.GetString(1),//nome
                    dr.GetString(2),//cpf
                    dr.GetDateTime(3),//data
                    Setor.ObterPorId(dr.GetInt32(4)),//setor
                    Cargo.ObterPorId(dr.GetInt32(5)),//cargo
                    dr.GetString(6),//email
                    dr.GetString(7),//senha
                    dr.GetBoolean(8)//ativo
                    );


            }
            cmd.Connection.Close();

            return usuario;
        }

        public static List<Usuario> ObterLista(string? nome = "")
        {
            List<Usuario> usuarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            if (nome == "")
            {
                cmd.CommandText = "select * from usuario order by nome";
            }
            else
            {
                cmd.CommandText = $"select * from usuario where nome like '%{nome}%' order by nome";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(new
                    (
                    dr.GetInt32(0),//id
                    dr.GetString(1),//nome
                    dr.GetString(2),//cpf
                    dr.GetDateTime(3),//data
                    Setor.ObterPorId(dr.GetInt32(4)),//setor
                    Cargo.ObterPorId(dr.GetInt32(5)),//cargo
                    dr.GetString(6),//email
                    dr.GetString(7),//senha
                    dr.GetBoolean(8)//ativo
                    ));
            }

            cmd.Connection.Close();
            return usuarios;
        }

        public static List<Usuario> ObterListaPorCargo(int cargoId)
        {
            List<Usuario> usuarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from usuario where id_cargo = {cargoId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add(new(
                    dr.GetInt32(0),//id
                    dr.GetString(1),//nome
                    dr.GetString(2),//cpf
                    dr.GetDateTime(3),//data
                    Setor.ObterPorId(dr.GetInt32(4)),//setor
                    Cargo.ObterPorId(dr.GetInt32(5)),//cargo
                    dr.GetString(6),//email
                    dr.GetString(7),//senha
                    dr.GetBoolean(8)//ativo
                    ));
            }

            cmd.Connection.Close();
            return usuarios;
        }

        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuario where email = '{email}' and senha = md5('{senha}')";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),//id
                    dr.GetString(1),//nome
                    dr.GetString(2),//cpf
                    dr.GetDateTime(3),//data
                    Setor.ObterPorId(dr.GetInt32(4)),//setor
                    Cargo.ObterPorId(dr.GetInt32(5)),//cargo
                    dr.GetString(6),//email
                    dr.GetString(7),//senha
                    dr.GetBoolean(8)//ativo
                    );
            }

            cmd.Connection.Close();
            return usuario;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spdata_nascimento", DataNascimento);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spid_setor", Setor.Id);
            cmd.Parameters.AddWithValue("spid_cargo", Cargo.Id);

            cmd.ExecuteNonQuery();
            
            cmd.Connection.Close();

        }

        public static void DesativarUsuario(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuario set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }

        public static void ReativarUsuario(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuario set ativo = 1 where id = {id}";
            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }
    }
}
