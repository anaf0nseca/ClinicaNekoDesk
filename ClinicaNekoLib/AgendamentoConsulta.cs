using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class AgendamentoConsulta
    {
        public int Id { get; set; }
        public Agendamento Agendamento { get; set; }
        public Consulta Consulta { get; set; }


        public AgendamentoConsulta()
        {
            Agendamento = new Agendamento();
            Consulta = new Consulta();
        }

        public AgendamentoConsulta(Agendamento agendamento, Consulta consulta)
        {
            Agendamento = agendamento;
            Consulta = consulta;
        }
        public AgendamentoConsulta(int id, Agendamento agendamento, Consulta consulta)
        {
            Id = id;
            Agendamento = agendamento;
            Consulta = consulta;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into agendamento_consulta(id_agendamento, id_consulta) values({Agendamento.Id}, {Consulta.Id})";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
