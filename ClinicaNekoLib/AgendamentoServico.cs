using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class AgendamentoServico
    {
        public int Id { get; set; }
        public Agendamento Agendamento { get; set; }
        public Servico Servico { get; set; }


        public AgendamentoServico()
        {
            Agendamento = new Agendamento();
            Servico = new Servico();
        }

        public AgendamentoServico(Agendamento agendamento, Servico servico)
        {
            Agendamento = agendamento;
            Servico = servico;
        }
        public AgendamentoServico(int id, Agendamento agendamento, Servico servico)
        {
            Id = id;
            Agendamento = agendamento;
            Servico = servico;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into agendamento_servico(id_agendamento, id_servico) values({Agendamento.Id}, {Servico.Id})";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
