using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Categoria
    {

        public int Id { get; set; }
        public string? Nome { get; set; }

        public Categoria() { }

        public Categoria(string? nome)
        {
            Nome = nome;
        }
        public Categoria(int id, string? nome)
        {
            Id = id;
            Nome = nome;
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM categoria where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                categoria = new(
                dr.GetInt32(0),
                dr.GetString(1)
                );
            }
            cmd.Connection.Close();

            return categoria;
        }

        public static List<Categoria> ObterLista()
        {
            List<Categoria> categorias = new List<Categoria>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from categoria";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                categorias.Add(new(
                dr.GetInt32(0),
                dr.GetString(1)
                ));
            }
            cmd.Connection.Close();

            return categorias;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_categoria_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from categoria where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

    }
}
