using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace examen_ap
{
    public partial class Examen : Form
    {
        Random random = new Random();
        private int numero_aleatorio;
        private int res_aleatoria;
        private int calificacion = 0;
        private int decision;
        private int matricula;
        private string respuesta_para_validar;
        int contador;
        private string[] arrA = new string[4];
        Pregunta pregunta = new Pregunta();
        
        /*static int a = 0;
        static int b = 1;
        static int c = 2;
        static int d = 3;*/
     
        public Examen(int matricula)
        {
            this.matricula = matricula;
            InitializeComponent();
            
        }

       
        public string decide()
        {
            if (radio_respuesta1.Checked == true) respuesta_para_validar = lbl_respuesta1.Text;
            else if (radio_respuesta2.Checked == true) respuesta_para_validar = lbl_respuesta2.Text;
            else if (radio_respuesta3.Checked == true) respuesta_para_validar = lbl_respuesta3.Text;
            else if (radio_respuesta4.Checked == true) respuesta_para_validar = lbl_respuesta4.Text;
            return respuesta_para_validar;
        }

        private void Examen_Load(object sender, EventArgs e)
        {
            
            pregunta.conectar();
           
            contador = 1;
            lbl_numero_pregunta.Text = contador.ToString();
            numero_aleatorio = random.Next(1, 78);


            lbl_pregunta.Text = pregunta.getPregunta(numero_aleatorio);

           
            lbl_respuesta1.Text = pregunta.getRespuesta(numero_aleatorio);
            lbl_respuesta2.Text = pregunta.getIncorrecta(numero_aleatorio , 1);
            lbl_respuesta3.Text = pregunta.getIncorrecta(numero_aleatorio, 2);
            lbl_respuesta4.Text = pregunta.getIncorrecta(numero_aleatorio ,3);
            


            if (pregunta.valida(decide(),numero_aleatorio) == true)
            {
                calificacion += 10;

            }
            pregunta.cerrar();

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            //int k, l, m, n;
            /*
            k = modificaA();
            l= modificaB();
            m =modificaC();
            n = modificaD();
            */
            string respuesta1, respuesta2, respuesta3, respuesta4;
           
            contador++;
          
            pregunta.conectar();
            lbl_numero_pregunta.Text = contador.ToString();
            numero_aleatorio = random.Next(1, 78);
            respuesta1= pregunta.getRespuesta(numero_aleatorio);
            respuesta2= pregunta.getIncorrecta(numero_aleatorio, 1);
            respuesta3= pregunta.getIncorrecta(numero_aleatorio, 2);
            respuesta4= pregunta.getIncorrecta(numero_aleatorio, 3);

            /*
            arrA[k] = respuesta1;
            arrA[l] = respuesta2;
            arrA[m] = respuesta3;
            arrA[n] = respuesta4;
            */
            lbl_pregunta.Text = pregunta.getPregunta(numero_aleatorio);


            lbl_respuesta1.Text = respuesta1;
            lbl_respuesta2.Text = respuesta2;
            lbl_respuesta3.Text = respuesta3;
            lbl_respuesta4.Text = respuesta4;


            if (pregunta.valida(decide(), numero_aleatorio) == true)
            {

                calificacion += 10;

            }//fin if
            pregunta.cerrar();
            if (contador == 11)
            {

                Intento intento = new Intento(calificacion,matricula);

                Resultados res = new Resultados();

                res.Show();

                Close();



            }//fin if
            
        }//fin btn_siguiente


      /* CÓDIGO PARA GENERA SEUDOALEATORIOEDAD... NO TIME FOR MORE...
      private int modificaA()
        {
            if (a == 0) a += 1;
           else  if (a == 1) a += 1;
            else if (a == 2) a += 1;
            else if (a == 3) a = 0;
            return a;
        }//fin modificaA
        private int modificaB()
        {
            if (b == 0) b += 1;
            else if (b == 1) b += 1;
            else if (b == 2) b += 1;
            else if (b == 3) b = 0;
            return b;
        }//fin modificaB
        private int modificaC()
        {
             if (c == 0) c += 1;
            else if (c == 1) c += 1;
            else if (c == 2) c += 1;
            else if (c == 3) c = 0;
            return c;
        }//fin modificaC
        private int modificaD()
        {
            if (d == 0) d += 1;
           else  if (d == 1) d += 1;
            else if (d == 2) d += 1;
            else if (d == 3) d = 0;
            return d;
        }//fin modificaD
        */

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }//fin class
}//fin namespace
