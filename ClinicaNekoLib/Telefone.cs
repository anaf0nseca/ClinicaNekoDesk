﻿using ClinicaNekoLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaNekoLib
{
    public class Telefone
    {

        public int Id { get; set; }
        public string? Numero {  get; set; }
        public string? Tipo { get; set; }

        public Telefone() { }

        public Telefone(string numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public Telefone(int id, string numero, string tipo)
        {
            Id = id;
            Numero = numero;
            Tipo = tipo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_insert";
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        public static Telefone ObterPorId(int id)
        {
            Telefone telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from telefone where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                telefone = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    );
            }
            cmd.Connection.Close();
            return telefone;
        }

        //public static List<Telefone> ObterListaPorUsuario(int idUsuario)
        //{
        //    List<Telefone> telefones = new();
        //    var cmd = Banco.Abrir();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = $"select * from telefone";

        //    return telefones;
        //}

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefone_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("sptipo", Tipo);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from telefone where id = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

    }

}
