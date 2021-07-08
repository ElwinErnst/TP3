using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using TP3.Entidades;
using TP3.Controladores;



namespace TP3
{
    class Program
    {
        //public static List<Usuario> usuarios;
        public static int idusuario;
        public static int puntos = 0;

        static void Main(string[] args)
        {
            //usuarios = new List<Usuario>();
            Conexion.OpenConexion();
            nUsuario.Menu();
            Conexion.CloseConexion();
        }
    }
}
