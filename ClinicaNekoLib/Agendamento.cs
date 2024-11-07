using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Agendamento
    {

        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public string? Status { get; set; }

        public Agendamento() { }

        public Agendamento(Usuario usuario, Paciente paciente, DateTime data, DateTime hora, string? status)
        {
            Usuario = usuario;
            Paciente = paciente;
            Data = data;
            Hora = hora;
            Status = status;
        }
        public Agendamento(int id, Usuario usuario, Paciente paciente, DateTime data, DateTime hora, string? status)
        {
            Id = id;
            Usuario = usuario;
            Paciente = paciente;
            Data = data;
            Hora = hora;
            Status = status;
        }

        public Agendamento(string? status)
        {
            Status = status;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_agendamento_insert";
            cmd.Parameters.AddWithValue("spid_usuario", Usuario.Id);
            cmd.Parameters.AddWithValue("spid_paciente", Paciente.Id);
            cmd.Parameters.AddWithValue("spdata", Data);
            cmd.Parameters.AddWithValue("sphora", Hora);
            cmd.Parameters.AddWithValue("spstatus", Status);


            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();

        }

        public void AlterarStatus(int Id, string Status)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update agendamento set status = '{Status} where id = {Id}'";

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Agendamento ObterPorId(int id)
        {
            Agendamento agendamento = new Agendamento();
            var cmd = Banco.Abrir();

            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                agendamento = new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Paciente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetString(5)

                    );
            }

            return agendamento;
        }

        public static List<Agendamento> ObterLista(int id = 0)
        {
            List<Agendamento> agendamentos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "select * from agendamento order by data";


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agendamentos.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Paciente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetString(5)

                    ));
            }

            cmd.Connection.Close();
            return agendamentos;

        }

        public static List<Agendamento> ObterListaPorPaciente(int pacienteId)
        {
            List<Agendamento> agendamentosPaciente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = $"select * from agendamento where id_paciente = {pacienteId} order by data";


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agendamentosPaciente.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Paciente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetString(5)

                    ));
            }

            cmd.Connection.Close();
            return agendamentosPaciente;

        }
        public static List<Agendamento> ObterListaPorUsuario(int usuarioId)
        {
            List<Agendamento> agendamentosUsuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = $"select * from agendamento where id_usuario = {usuarioId} order by data";


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agendamentosUsuario.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Paciente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetString(5)

                    ));
            }

            cmd.Connection.Close();
            return agendamentosUsuario;

        }

        public static List<Agendamento> ObterListaPorStatus(string status)
        {
            List<Agendamento> agendamentosStatus = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = $"select * from agendamento where status = {status} order by data";


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agendamentosStatus.Add(new(
                    dr.GetInt32(0),
                    Usuario.ObterPorId(dr.GetInt32(1)),
                    Paciente.ObterPorId(dr.GetInt32(2)),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetString(5)

                    ));
            }

            cmd.Connection.Close();
            return agendamentosStatus;

        }

        
    }
}