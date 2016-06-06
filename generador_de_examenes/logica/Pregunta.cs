using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Pregunta
    {
        private string pregunta;
        private string consulta;
        private string incorrecta;
        static string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
         "Data Source= ./main_db.accdb";
         static OleDbConnection Conexion = new OleDbConnection(conexion);

        public void conectar()
        {
            
           
           Conexion.Open();     

        }

        public void cerrar()
        {

            Conexion.Close();
        }



        //obtener una pregunta de la base de datos
        public string getPregunta(int n)
        {
          //conectar();

            //string pregunta;
            int id = n;
            consulta = "SELECT PREGUNTA FROM PREGUNTA WHERE IDPREGUNTA = " + id;

            OleDbCommand ordenSQL = new OleDbCommand(consulta, Conexion);

            OleDbDataReader lector = ordenSQL.ExecuteReader();
            while (lector.Read())
            {
             
                pregunta = lector.GetString(0);
               
            }

            return pregunta;
          

        }//fin getPregunta

        public string getRespuesta(int n)
        {

            int id = n;
            consulta = "SELECT RESPUESTA FROM PREGUNTA WHERE IDPREGUNTA = " + id;

            OleDbCommand ordenSQL = new OleDbCommand(consulta, Conexion);

            OleDbDataReader lector = ordenSQL.ExecuteReader();
            while (lector.Read())
            {
                //lector.Read(3);
                pregunta = lector.GetString(0);

            }

            return pregunta;
            
        }//fin getRespuesta

        
        public string getIncorrecta (int n, int i)
        {
            int id = n;

            consulta = "SELECT INCORRECTA" +i +" FROM INCORRECTA WHERE IDINCORRECTA = " + id;

            OleDbCommand ordenSQL = new OleDbCommand(consulta, Conexion);

            OleDbDataReader lector = ordenSQL.ExecuteReader();
            while (lector.Read())
            {
                //lector.Read(3);
                incorrecta = lector.GetString(0);

            }

            return incorrecta;

        }


        //valida Respuesta
        public bool valida(string a, int n)
        {

            bool value;
            string resp;
            resp = getRespuesta(n);
            if (a == resp) value = true;
            else value = false;
            return value;

        }






    }//fin class
}//fin namespaces
