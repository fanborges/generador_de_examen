using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Conecta
    {
        static string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
         "Data Source= ./main_db.accdb";
        static OleDbConnection Conexion = new OleDbConnection(conexion);

        public void abrir()
        {
            Conexion.Open();

        }
        public void cierra()
        {
            Conexion.Close();
        }

        public void ejecuta(string a)
        {
           
            
            OleDbCommand ordenSQL = new OleDbCommand(a, Conexion);
            ordenSQL.ExecuteNonQuery();
        }
        



    }//fin class
}//fin logica
