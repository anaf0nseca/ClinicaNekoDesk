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
    }
}
