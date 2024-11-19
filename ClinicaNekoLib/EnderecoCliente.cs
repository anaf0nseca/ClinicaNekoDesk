using ClinicaNekoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class EnderecoCliente
    {

        public int Id { get; set; }
        public Endereco Endereco { get; set; }
        public Cliente Cliente { get; set; }


        public EnderecoCliente()
        {
            Endereco = new Endereco();
            Cliente = new Cliente();
        }

        public EnderecoCliente(Endereco endereco, Cliente cliente)
        {
            Endereco = endereco;
            Cliente = cliente;
        }
        public EnderecoCliente(int id, Endereco endereco, Cliente cliente)
        {
            Id = id;
            Endereco = endereco;
            Cliente = cliente;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into endereco_cliente(id_endereco, id_cliente) values({Endereco.Id}, {Cliente.Id})";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<EnderecoCliente> ObterListaPorCliente(int clienteId)
        {
            List<EnderecoCliente> enderecoCliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from endereco_cliente where id_cliente = {clienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecoCliente.Add(new(
                dr.GetInt32(0),
                Endereco.ObterPorId(dr.GetInt32(1)),
                Cliente.ObterPorId(dr.GetInt32(2))
                    ));
            }

            cmd.Connection.Close();
            return enderecoCliente;
        }


    }
}
