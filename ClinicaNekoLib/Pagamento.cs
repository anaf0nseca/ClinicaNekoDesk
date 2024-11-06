using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Pagamento
    {

        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public double Valor { get; set; }

        public Pagamento() { }

        public Pagamento(Pedido pedido, FormaPagamento formaPagamento, double valor)
        {
            Pedido = pedido;
            FormaPagamento = formaPagamento;
            Valor = valor;
        }
        public Pagamento(int id, Pedido pedido, FormaPagamento formaPagamento, double valor)
        {
            Id = id;
            Pedido = pedido;
            FormaPagamento = formaPagamento;
            Valor = valor;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_pagamento_insert";
            cmd.Parameters.AddWithValue("spid_pedido", Pedido.Id);
            cmd.Parameters.AddWithValue("spid_formapgto", FormaPagamento.Id);
            cmd.Parameters.AddWithValue("spid_valor", Valor);


            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static Pagamento ObterPorId(int id)
        {
            Pagamento pagamento = new Pagamento();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pagamento where id = {id}";
            var dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                pagamento = new(
                    dr.GetInt32(0),
                    Pedido.ObterPorId(dr.GetInt32(1)),
                    FormaPagamento.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3)

                    );
            }

            return pagamento;
        }

        public static List<Pagamento> ObterLista(int id = 0)
        {
            List<Pagamento> pagamentos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "select * from pagamento order by data";


            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pagamentos.Add(new(
                    dr.GetInt32(0),
                    Pedido.ObterPorId(dr.GetInt32(1)),
                    FormaPagamento.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3)


                    ));
            }

            cmd.Connection.Close();
            return pagamentos;

        }

        public static List<Pagamento> ObterListaPorPedido(int idPedido)
        {
            List<Pagamento> pagamentosPedido = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from pagamentos where id_pedido = {idPedido}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pagamentosPedido.Add(new(
                    dr.GetInt32(0),
                    Pedido.ObterPorId(dr.GetInt32(1)),
                    FormaPagamento.ObterPorId(dr.GetInt32(2)),
                    dr.GetDouble(3)

                    ));
            }

            cmd.Connection.Close();
            return pagamentosPedido;
        }

    }
}
