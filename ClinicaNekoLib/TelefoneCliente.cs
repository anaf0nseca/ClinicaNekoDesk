using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class TelefoneCliente
    {
        public int Id { get; set; }
        public Telefone Telefone { get; set; }
        public Cliente Cliente { get; set; }


        public TelefoneCliente()
        {
            Telefone = new Telefone();
            Cliente = new Cliente();
        }

        public TelefoneCliente(Telefone telefone, Cliente cliente)
        {
            Telefone = telefone;
            Cliente = cliente;
        }
        public TelefoneCliente(int id, Telefone telefone, Cliente cliente)
        {
            Id = id;
            Telefone = telefone;
            Cliente = cliente;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into telefone_cliente(id_telefone, id_cliente) values({Telefone.Id}, {Cliente.Id})";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static List<TelefoneCliente> ObterListaPorCliente(int clienteId)
        {
            List<TelefoneCliente> telefoneCliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from telefone_cliente where id_cliente = {clienteId}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefoneCliente.Add(new(
                dr.GetInt32(0),
                Telefone.ObterPorId(dr.GetInt32(1)),
                Cliente.ObterPorId(dr.GetInt32(2))
                    ));
            }

            cmd.Connection.Close();
            return telefoneCliente;
        }

    }
}
