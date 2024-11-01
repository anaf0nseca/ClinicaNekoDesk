using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Cirurgia
    {
        public int Id { get; set; }

        public Especialidade Especialidade { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Cirurgia() { }

        public Cirurgia(Especialidade especialidade, string nome, double valor)
        {
            Especialidade = especialidade;
            Nome = nome;
            Valor = valor;
        }
        public Cirurgia(int id, Especialidade especialidade, string nome, double valor)
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
            cmd.CommandText = "sp_cirurgia_insert";
            cmd.Parameters.AddWithValue("spid_especialidade", Especialidade);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spvalor", Valor);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Cirurgia ObterPorId(int id)
        {
            Cirurgia cirurgia = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM cirurgia where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cirurgia = new(
                dr.GetInt32(0),
                Especialidade.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2),
                dr.GetDouble(3)
                );
            }
            cmd.Connection.Close();

            return cirurgia;
        }

        public static List<Cirurgia> ObterLista()
        {
            List<Cirurgia> cirurgias = new List<Cirurgia>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cirurgia";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cirurgias.Add(new(
                dr.GetInt32(0),
                Especialidade.ObterPorId(dr.GetInt32(1)),
                dr.GetString(2),
                dr.GetDouble(3)
                ));
            }
            cmd.Connection.Close();

            return cirurgias;
        }
    }
}
