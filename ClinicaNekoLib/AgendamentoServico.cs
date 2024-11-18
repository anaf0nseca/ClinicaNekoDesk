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

        public static List<AgendamentoServico> ObterListaPorAgendamento(int agendamentoId)
        {
            List<AgendamentoServico> agendamentoServicos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from consulta where id_agendamento = {agendamentoId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agendamentoServicos.Add(new(
                dr.GetInt32(0),
                Agendamento.ObterPorId(dr.GetInt32(1)),
                Servico.ObterPorId(dr.GetInt32(2))
                    ));
            }

            cmd.Connection.Close();
            return agendamentoServicos;
        }

    }
}
