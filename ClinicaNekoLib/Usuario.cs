using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
        public Setor Setor {  get; set; }
        //public Cargo Cargo { get; set; }
        public string Senha { get; set; }




    }

}
