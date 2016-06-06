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
    public partial class Registro : Form
    {

        string n, pat, mater;
        int matri, seme;

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Registro()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            n = txt_box_nombre.Text;
            pat = txt_box_paterno.Text;
            mater = txt_box_materno.Text;
            matri = Int32.Parse(txt_box_matricula.Text);
            seme = Int32.Parse(txt_box_semestre.Text);
            Alumno alumno = new Alumno(n,pat,mater,matri,seme);
            Examen examen = new Examen(matri);
            examen.Show();
            Close();
        }

        /*public void agrega()
        {


            Alumno alumno = new Alumno();

        }*/


    }//fin class
}//fin namespace
