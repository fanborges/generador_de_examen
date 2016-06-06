using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_ap
{
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }

        private void linklbl_intento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Totales_intento totales = new Totales_intento();
            totales.Show();
            Close();
        }

        private void linklbl_alumno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Totales_alumnos totales = new Totales_alumnos();
            totales.Show();
            Close();

        }

        private void Resultados_Load(object sender, EventArgs e)
        {

        }
    }
}
