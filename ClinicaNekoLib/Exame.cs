using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Exame
    {

        public int Id { get; set; }

        public Especialidade Especialidade { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Exame() { }

        public Exame(Especialidade especialidade, string nome, double valor)
        {
            Especialidade = especialidade;
            Nome = nome;
            Valor = valor;
        }
        public Exame(int id, Especialidade especialidade, string nome, double valor)
        {
            Id = id;
            Especialidade = especialidade;
            Nome = nome;
            Valor = valor;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_exame_insert";
            cmd.Parameters.AddWithValue("spid_especialidade", Especialidade);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spvalor", Valor);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Exame ObterPorId(int id)
        {
            Exame exame = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM exame where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                exame = new(
                dr.GetInt32(0),
                Especialidade.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2),
                dr.GetDouble(3)
                );
            }
            cmd.Connection.Close();

            return exame;
        }

        public static List<Exame> ObterLista()
        {
            List<Exame> exames = new List<Exame>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from exame";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                exames.Add(new(
                dr.GetInt32(0),
                Especialidade.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2),
                dr.GetDouble(3)
                ));
            }
            cmd.Connection.Close();

            return exames;
        }

        public static List<Exame> ObterListaPorEspecialidade(int especialidadeId)
        {
            List<Exame> exames = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from exame where id_especialidade = {especialidadeId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                exames.Add(new(
                dr.GetInt32(0),
                Especialidade.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2),
                dr.GetDouble(3)
                    ));
            }

            cmd.Connection.Close();
            return exames;
        }
    }
}
