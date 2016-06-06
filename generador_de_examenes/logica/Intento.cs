using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Intento
    {
        //campos
        string inserta;
        int calificacion;
        int matricula;
        public Intento(int calif, int matri)
        {
            agregaIntento(calif, matri);

        }
        public void agregaIntento(int calif, int matri)
        {
            Conecta conecta = new Conecta();
            conecta.abrir();      
            inserta = "INSERT INTO INTENTO (CALIFICACION, MATRICULA) VALUES ('" + calif + "','" + matri + "')";
            conecta.ejecuta(inserta);
            conecta.cierra();            
        }//fin agregaIntento    
        
       
        
        
            
    }//fin class
}//fin namespace
