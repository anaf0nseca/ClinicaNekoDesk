using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Cliente
    {

        public int Id { get; set; }
        public string? Nome { get; set; }    
        public string Cpf   { get; set; }
        public DateTime? Data_Nascimento { get; set; }
        public string Email { get; set; }

        public Cliente()
        {

        }

        public Cliente(string? nome, string cpf, DateTime? data_Nascimento, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Data_Nascimento = data_Nascimento;
            Email = email;
        }

        public Cliente(int id, string? nome, string cpf, DateTime? data_Nascimento, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Data_Nascimento = data_Nascimento;
            Email = email;
        }

        public Cliente(int id, string? nome, DateTime? data_Nascimento, string email)
        {
            Id = id;
            Nome = nome;
            Data_Nascimento = data_Nascimento;
            Email = email;
        }




    }
}
