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
    public partial class Totales_intento : Form
    {
        public Totales_intento()
        {
            InitializeComponent();
        }

        private void Totales_intento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'main_dbDataSet.VISTA1' Puede moverla o quitarla según sea necesario.
            this.vISTA1TableAdapter.Fill(this.main_dbDataSet.VISTA1);

        }

        private void btn_totales_por_alumno_Click(object sender, EventArgs e)
        {
            Totales_alumnos totales = new Totales_alumnos();
            totales.Show();
            Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
