﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class AgendamentoCirurgia
    {
        public int Id { get; set; }
        public Agendamento Agendamento { get; set; }
        public Cirurgia Cirurgia { get; set; }


        public AgendamentoCirurgia()
        {
            Agendamento = new Agendamento();
            Cirurgia = new Cirurgia();
        }

        public AgendamentoCirurgia(Agendamento telefone, Cirurgia cirurgia)
        {
            Agendamento = telefone;
            Cirurgia = cirurgia;
        }
        public AgendamentoCirurgia(int id, Agendamento telefone, Cirurgia cirurgia)
        {
            Id = id;
            Agendamento = telefone;
            Cirurgia = cirurgia;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into agendamento_cirurgia(id_agendamento, id_cirurgia) values({Agendamento.Id}, {Cirurgia.Id})";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}