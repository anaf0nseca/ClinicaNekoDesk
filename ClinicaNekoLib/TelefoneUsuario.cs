using ClinicaNekoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class TelefoneUsuario
    {

        public int Id {  get; set; }
        public Telefone Telefone { get; set; }
        public Usuario Usuario { get; set; }


        public TelefoneUsuario()
        {
            Telefone = new Telefone();
            Usuario = new Usuario();
        }

        public TelefoneUsuario(Telefone telefone, Usuario usuario)
        {
            Telefone = telefone;
            Usuario = usuario;
        }
        public TelefoneUsuario(int id, Telefone telefone, Usuario usuario)
        {
            Id = id;
            Telefone = telefone;
            Usuario = usuario;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into telefone_usuario(id_telefone, id_usuario) values({Telefone.Id}, {Usuario.Id})";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<TelefoneUsuario> ObterListaPorUsuario(int usuarioId)
        {
            List<TelefoneUsuario> telefoneUsuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from telefone_usuario where id_usuario = {usuarioId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefoneUsuario.Add(new(
                dr.GetInt32(0),
                Telefone.ObterPorId(dr.GetInt32(1)),
                Usuario.ObterPorId(dr.GetInt32(2))
                    ));
            }

            cmd.Connection.Close();
            return telefoneUsuario;
        }

    }
}
