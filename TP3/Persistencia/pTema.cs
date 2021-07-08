using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TP3.Entidades;
using TP3.Controladores;

namespace TP3.Persistencia
{
    class pTema
    {
        public static Tema GetTemaById(int id)
        {
            Tema t = new Tema();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Tema WHERE Id=@id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                t.Id = obdr.GetInt32(0);
                t.Nombre = obdr.GetString(1);
            }
            return t;
        }

        public static List<Tema> GetAll()
        {
            List<Tema> temas = new List<Tema>();

            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Tema");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Tema t = new Tema();
                t.Id = obdr.GetInt32(0);
                t.Nombre = obdr.GetString(1);
                temas.Add(t);
            }
            return temas;
        }
    }
}