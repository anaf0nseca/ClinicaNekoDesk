using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Cargo
    {

        public int Id { get; set; }
        public Setor Setor { get; set; }
        public string Nome { get; set; }


        public Cargo(){}

        public Cargo(Setor setor, string nome)
        {
            Setor = setor;
            Nome = nome;
        }
        public Cargo(int id, Setor setor, string nome)
        {
            Id = id;
            Setor = setor;
            Nome = nome;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cargo_insert";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static Cargo ObterPorId(int id)
        {
            Cargo cargo = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from cargo where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cargo = new(
                    dr.GetInt32(0),
                    Setor.ObterPorId(dr.GetInt32(1)),
                    dr.GetString(2)
                    );
            }
            cmd.Connection.Close();
            return cargo;
        }

        public static List<Setor> ObterLista()
        {
            List<Setor> cargos = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from setor";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cargos.Add(new(
                    dr.GetInt32(0),
                    //Setor.ObterPorId(dr.GetInt32(1)),

                    dr.GetString(1)
                    ));
            }

            cmd.Connection.Close();
            return cargos;
        }

        //Atualizar dados do setor no banco
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_setor_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }


    }
}
