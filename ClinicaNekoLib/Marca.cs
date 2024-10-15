using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Marca
    {

        public int Id { get; set; }
        public string? Nome { get; set; }

        public Marca() { }

        public Marca(string? nome)
        {
            Nome = nome;
        }
        public Marca(int id, string? nome)
        {
            Id = id;
            Nome = nome;
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_marca_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public static Marca ObterPorId(int id)
        {
            Marca marca = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM marca where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                marca = new(
                dr.GetInt32(0),
                dr.GetString(1)
                );
            }
            cmd.Connection.Close();

            return marca;
        }

        public static List<Marca> ObterLista()
        {
            List<Marca> marcas = new List<Marca>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from marca";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                marcas.Add(new(
                dr.GetInt32(0),
                dr.GetString(1)
                ));
            }
            cmd.Connection.Close();

            return marcas;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_marca_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from marca where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

    }
}
