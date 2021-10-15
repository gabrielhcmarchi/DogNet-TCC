﻿using DogNet.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DogNet.Controllers
{
    public static class FrontSupport
    {

        public static List<Models.Instituicoes> ReturnInstituicoes()
        {

            using var con = new SqliteConnection("Filename=./dados.db");
            con.Open();
            string stm = "SELECT Nome FROM Instituicoes";

            using var cmd = new SqliteCommand(stm, con);
            using SqliteDataReader rdr = cmd.ExecuteReader();

            List<Instituicoes> inst = new List<Instituicoes>();

            while (rdr.Read())
            {
                Instituicoes vwInst = new Instituicoes();
                vwInst.Nome = rdr.GetString(0);
                inst.Add(vwInst);
            }

            con.Close();
            return inst;

        }

        public static string SelectReader(string rtn)
        {

            using var con = new SqliteConnection("Filename=./dados.db");
            con.Open();
            string stm = "SELECT * FROM Instituicoes";

            using var cmd = new SqliteCommand(stm, con);
            using SqliteDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Instituicoes vwInst = new Instituicoes();
                if(vwInst.Nome == rdr.GetString(0))
                {
                    rtn = rdr.GetString(0);
                }
            }

            con.Close();
            return rtn;

        }
    }
}
