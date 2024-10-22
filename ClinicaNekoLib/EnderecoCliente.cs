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

    }
}
