using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Raca
    {

        public int Id { get; set; }
        public Especie Especie { get; set; }

        public string? Nome { get; set; }

        public Raca() { }

        public Raca(Especie especie, string? nome)
        {
            Especie = especie;
            Nome = nome;
        }

        public Raca(int id, Especie especie, string? nome)
        {
            Id = id;
            Especie = especie;
            Nome = nome;
        }


        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_raca_insert";
            cmd.Parameters.AddWithValue("spid_especie", Especie.Id);
            cmd.Parameters.AddWithValue("spnome", Nome);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Raca ObterPorId(int id)
        {
            Raca raca = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM raca where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                raca = new(
                dr.GetInt32(0),
                Especie.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2)
                );
            }
            cmd.Connection.Close();

            return raca;
        }

        public static List<Raca> ObterLista()
        {
            List<Raca> racas = new List<Raca>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from raca";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                racas.Add(new(
                dr.GetInt32(0),
                Especie.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2)
                ));
            }
            cmd.Connection.Close();

            return racas;
        }

        public static List<Raca> ObterListaPorEspecie(int especieId)
        {
            List<Raca> racas = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from raca where id_especie = {especieId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                racas.Add(new(
                    dr.GetInt32(0),
                    Especie.ObterPorId(dr.GetInt32(1)),
                    dr.GetString(2)
                    ));
            }

            cmd.Connection.Close();
            return racas;
        }
    }
}
