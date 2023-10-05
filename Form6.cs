using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remiseria
{
    public partial class Form6 : Form
    {
        Viajes oviaje;
        Barrio obarrio;
        DataTable tviaje;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
           oviaje = new Viajes();
           obarrio = new Barrio();
            tviaje = oviaje.GetDataViajes();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (rbDestino.Checked)
            {
                string opcion = "desdebarrio";
                oviaje.cantidadViajes(dataGridView1, opcion);
            }
            else
            {
                string opcion = "desdebarrio";
                oviaje.cantidadViajes(dataGridView1, opcion);
            }
        }
    }
}
