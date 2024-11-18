using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class AgendamentoExame
    {

        public int Id { get; set; }
        public Agendamento Agendamento { get; set; }
        public Exame Exame { get; set; }


        public AgendamentoExame()
        {
            Agendamento = new Agendamento();
            Exame = new Exame();
        }

        public AgendamentoExame(Agendamento agendamento, Exame exame)
        {
            Agendamento = agendamento;
            Exame = exame;
        }
        public AgendamentoExame(int id, Agendamento agendamento, Exame exame)
        {
            Id = id;
            Agendamento = agendamento;
            Exame = exame;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into agendamento_exame(id_agendamento, id_exame) values({Agendamento.Id}, {Exame.Id})";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<AgendamentoExame> ObterListaPorAgendamento(int agendamentoId)
        {
            List<AgendamentoExame> agendamentoExames = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from agendamento_exame where id_agendamento = {agendamentoId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agendamentoExames.Add(new(
                dr.GetInt32(0),
                Agendamento.ObterPorId(dr.GetInt32(1)),
                Exame.ObterPorId(dr.GetInt32(2))
                    ));
            }

            cmd.Connection.Close();
            return agendamentoExames;
        }

    }
}
