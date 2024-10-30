using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Paciente
    {

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
   
        public Raca Raca { get; set; }
        public string? Nome { get; set; }
        public string? Cor { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }

        public Paciente() { }

        public Paciente(Cliente cliente, Raca raca, string? nome, string? cor, int idade, double peso)
        {
            Cliente = cliente;
            Raca = raca;
            Nome = nome;
            Cor = cor;
            Idade = idade;
            Peso = peso;
        }

        public Paciente(int id, Cliente cliente,  Raca raca, string? nome, string? cor, int idade, double peso)
        {
            Id = id;
            Cliente = cliente;
            Raca = raca;
            Nome = nome;
            Cor = cor;
            Idade = idade;
            Peso = peso;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_paciente_insert";
            cmd.Parameters.AddWithValue("spid_cliente", Cliente.Id);
            cmd.Parameters.AddWithValue("spid_raca", Raca.Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcor", Cor);
            cmd.Parameters.AddWithValue("spidade", Idade);
            cmd.Parameters.AddWithValue("sppeso", Peso);

            //Retorna o valor da primeira coluna da primeira linha
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Paciente ObterPorId(int id)
        {
            Paciente paciente = new();
            var cmd = Banco.Abrir();
            //Por padrão o CommandType é tipo .Text
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT * FROM paciente where id = {id};";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                paciente = new(
                dr.GetInt32(0),
                Cliente.ObterPorId(dr.GetInt32(1)),
                Raca.ObterPorId(dr.GetInt32(2)),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetInt32(5),
                dr.GetDouble(6)
                );
            }
            cmd.Connection.Close();

            return paciente;
        }

        public static List<Paciente> ObterLista()
        {
            List<Paciente> pacientes = new List<Paciente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from paciente";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pacientes.Add(new(
                dr.GetInt32(0),
                Cliente.ObterPorId(dr.GetInt32(1)),
                Raca.ObterPorId(dr.GetInt32(2)),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetInt32(5),
                dr.GetDouble(6)
                ));
            }
            cmd.Connection.Close();

            return pacientes;
        }

        public static List<Paciente> ObterListaPorCliente(int clienteId)
        {
            List<Paciente> pacientes = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from paciente where id_cliente = {clienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pacientes.Add(new(
                dr.GetInt32(0),
                Cliente.ObterPorId(dr.GetInt32(1)),
                Raca.ObterPorId(dr.GetInt32(2)),
                dr.GetString(3),
                dr.GetString(4),
                dr.GetInt32(5),
                dr.GetDouble(6)
                    ));
            }

            cmd.Connection.Close();
            return pacientes;
        }

    }
}
