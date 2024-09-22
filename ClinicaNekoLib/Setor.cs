using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Setor
    {

        public int Id { get; set; }
        public string? Nome { get; set; }


        public Setor()
        {

        }
        public Setor(string nome)
        {
            Nome = nome;
        }
        public Setor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        //Inserir novo setor no banco
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_setor_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }

            cmd.Connection.Close();
        }
       
        public static Setor ObterPorId(int id)
        {
            Setor setor = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from setor where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                setor = new(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    );
            }
            cmd.Connection.Close();
            return setor;
        }

        public static List<Setor> ObterLista()
        {
            List<Setor> setores = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                setores.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    ));
            }

            cmd.Connection.Close();
            return setores;
        }

        //Atualizar dados do setor no banco
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_setor_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
        
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        
        }


    }
}
