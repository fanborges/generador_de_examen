using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Alumno
    {
        //campos
        private string nombre, paterno, materno, inserta, obten;
        private int matricula, semestre;
        static string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;" +
        "Data Source= ./main_db.accdb";
        static OleDbConnection Conexion = new OleDbConnection(conexion);
        //constructores
        public Alumno (string nombre, string paterno, string materno, int matricula, int semestre)
        {
            this.nombre = nombre;
            this.paterno = paterno;
            this.materno = materno;
            this.matricula = matricula;
            this.semestre = semestre;
            registra(nombre, paterno, materno, matricula, semestre);
        }

        public Alumno()
        {
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;

        }
        public string getNombre()
        {
            return nombre;
        }
        public void setPaterno(string paterno)
        {
            this.paterno = paterno;

        }
        public string getPaterno()
        {
            return paterno;
        }
        public void setMaterno(string materno)
        {
            this.materno = materno;

        }
        public string getMaterno()
        {
            return materno;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;

        }
        public int getMatricula()
        {
            return matricula;
        }
        public void setSemestre(int semestre)
        {
            this.semestre = semestre;

        }
        public int getSemestre()
        {
            return semestre;
        }

       /* public bool consultaMatricula(int a)
        {
            bool value;
            int con=-1;

            Conecta conecta = new Conecta();
            conecta.abrir();
            inserta = "SELECT COUNT (MATRICULA) INTO " + con + " FROM ALUMNO WHERE IDMATRICULA = " + a;

            conecta.cierra();

            if ()


        }*/

        public void registra(string nombre, string paterno, string materno, int matricula, int semestre)
        {
            Conecta conecta = new Conecta();
            conecta.abrir();
            inserta = "INSERT INTO ALUMNO (NOMBRE,PATERNO,MATERNO,MATRICULA,SEMESTRE) VALUES ('" + nombre + "','" + paterno + "','" + materno + "','" + matricula + "','" + semestre + "')";
            conecta.ejecuta(inserta);
            conecta.cierra();
        }//fin registra


       /* public void obtenNomAlumno()
        {

            Conexion.Open();
            obten = "SELECT DISTINCT ALUMNO FROM ALUMNO";
            OleDbCommand ordenSQL = new OleDbCommand(obten, Conexion);

            OleDbDataReader lector = ordenSQL.ExecuteReader();
            while (lector.Read())
            {

                db_nombre = lector.GetString(0);

            }
           db_nombre = lector.GetString(0);

            //return db_nombre;



            //conecta.ejecuta(inserta); 
            Conexion.Close();

          
        }//fin registra
        */






    }//fin class
}//fin namespace
