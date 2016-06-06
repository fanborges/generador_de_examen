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
using System.Data.OleDb;

namespace examen_ap
{
    public partial class Acceso : Form
    {
       private OleDbConnection Conexion;
        private string consulta;
        private string pregunta;
        private int matricula;
        public Acceso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_presentar_examen_Click(object sender, EventArgs e)
        {
            matricula = Int32.Parse(txt_box_ingresa_matricula.Text);
            Examen examen = new Examen(matricula);
            examen.Show();
        }

        private void link_registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }

        private void btn_consultar_datos_Click(object sender, EventArgs e)
        {
            Resultados resultados = new Resultados();
            resultados.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
