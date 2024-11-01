using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Especialidade() { }

        public Especialidade(string nome)
        {
            Nome = nome;
        }
        public Especialidade(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_especialidade_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Especialidade ObterPorId(int id)
        {
            Especialidade especialidade = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM especialidade where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                especialidade = new(
                dr.GetInt32(0),
                dr.GetString(1)
         
                );
            }
            cmd.Connection.Close();

            return especialidade;
        }

        public static List<Especialidade> ObterLista()
        {
            List<Especialidade> especialidades = new List<Especialidade>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from especialidade";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                especialidades.Add(new(
                dr.GetInt32(0),
                dr.GetString(1)
                ));
            }
            cmd.Connection.Close();

            return especialidades;
        }
    }
}
