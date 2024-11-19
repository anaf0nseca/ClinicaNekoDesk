using ClinicaNekoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class EnderecoUsuario
    {

        public int Id { get; set; }
        public Endereco Endereco { get; set; }
        public Usuario Usuario { get; set; }


        public EnderecoUsuario()
        {
            Endereco = new Endereco();
            Usuario = new Usuario();
        }

        public EnderecoUsuario(Endereco endereco, Usuario usuario)
        {
            Endereco = endereco;
            Usuario = usuario;
        }
        public EnderecoUsuario(int id, Endereco endereco, Usuario usuario)
        {
            Id = id;
            Endereco = endereco;
            Usuario = usuario;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into endereco_usuario(id_endereco, id_usuario) values({Endereco.Id}, {Usuario.Id})";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


        public static List<EnderecoUsuario> ObterListaPorUsuario(int usuarioId)
        {
            List<EnderecoUsuario> enderecoUsuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from endereco_usuario where id_usuario = {usuarioId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecoUsuario.Add(new(
                dr.GetInt32(0),
                Endereco.ObterPorId(dr.GetInt32(1)),
                Usuario.ObterPorId(dr.GetInt32(2))
                    ));
            }

            cmd.Connection.Close();
            return enderecoUsuario;
        }


    }
}
