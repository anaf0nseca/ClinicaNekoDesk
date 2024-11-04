using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class FormaPagamento
    {
     

            public int Id { get; set; }
            public string? Nome { get; set; }


            public FormaPagamento()
            {

            }
            public FormaPagamento(string nome)
            {
                Nome = nome;
            }
            public FormaPagamento(int id, string nome)
            {
                Id = id;
                Nome = nome;
            }

            //Inserir novo setor no banco
            public void Inserir()
            {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into forma_pagamento (nome) values ('{Nome}')";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            }

            public static FormaPagamento ObterPorId(int id)
            {
                FormaPagamento forma = new();
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from forma_pagamento where id = {id}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    forma = new(
                        dr.GetInt32(0),
                        dr.GetString(1)
                        );
                }
                cmd.Connection.Close();
                return forma;
            }

            public static List<FormaPagamento> ObterLista()
            {
                List<FormaPagamento> formas = new();
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from forma_pagamento";
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    formas.Add(new(
                        dr.GetInt32(0),
                        dr.GetString(1)
                        ));
                }

                cmd.Connection.Close();
                return formas;
            }

            //Atualizar dados do setor no banco

            public bool Atualizar()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update forma_pagamento " +
                    $"set nome = '{Nome}' where id = {Id}";
                cmd.Connection.Close();
                return cmd.ExecuteNonQuery() > 0 ? true : false;


            }

        }

        }
    }
