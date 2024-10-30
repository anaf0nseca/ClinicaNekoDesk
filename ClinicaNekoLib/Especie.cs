using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Especie
    {

        public int Id { get; set; }

        public string? Nome { get; set; }

        public Especie() { }

        public Especie(string? nome)
        {
            Nome = Nome;
        }
        public Especie(int id, string? nome)
        {
            Id = id;
            Nome = nome;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_especie_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();


        }

        public static Especie ObterPorId(int id)
        {
            Especie especie = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM especie where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                especie = new(
                dr.GetInt32(0),
                dr.GetString(1)
                );
            }
            cmd.Connection.Close();

            return especie;
        }

        public static List<Especie> ObterLista()
        {
            List<Especie> especies = new List<Especie>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from especie";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                especies.Add(new(
                dr.GetInt32(0),
                dr.GetString(1)
                ));
            }
            cmd.Connection.Close();

            return especies;
        }
    }
}
