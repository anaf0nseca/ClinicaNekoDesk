using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Servico() { }

        public Servico(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public Servico(int id, string nome, double valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_servico_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spvalor", Valor);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Servico ObterPorId(int id)
        {
            Servico servico = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM servico where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                servico = new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetDouble(2)
                );
            }
            cmd.Connection.Close();

            return servico;
        }

        public static List<Servico> ObterLista()
        {
            List<Servico> servicos = new List<Servico>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from servico";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                servicos.Add(new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetDouble(2)
                ));
            }
            cmd.Connection.Close();

            return servicos;
        }

    }
}
