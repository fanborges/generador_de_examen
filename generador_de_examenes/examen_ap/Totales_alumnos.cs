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
    public partial class Totales_alumnos : Form
    {
        public Totales_alumnos()
        {
            InitializeComponent();
        }

        private void Totales_alumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'main_dbDataSet.TOTALES' Puede moverla o quitarla según sea necesario.
            this.tOTALESTableAdapter.Fill(this.main_dbDataSet.TOTALES);

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_totales_por_intento_Click(object sender, EventArgs e)
        {
            Totales_intento totales = new Totales_intento();
            totales.Show();
            Close();
        }
    }
}
