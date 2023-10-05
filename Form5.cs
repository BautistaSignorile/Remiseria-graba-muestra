using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remiseria
{
    public partial class Form5 : Form
    {
        Chofer oChofer;
        DataTable tChofer;
        Viajes oViaje;
        DataTable tViaje;
        Barrio oBarrio;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            oBarrio = new Barrio();
            oChofer = new Chofer();
            tChofer = oChofer.GetDataChofer();
            oViaje = new Viajes();
            tViaje = oViaje.GetDataViajes();

            listBox1.DisplayMember = "nombre";
            listBox1.ValueMember = "chofer";
            listBox1.DataSource = tChofer;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow fila in tViaje.Rows)
            {
                if (fila["chofer"].ToString() == listBox1.SelectedValue.ToString())
                {
                    string desdeBarrio = oBarrio.nombreBarrio(int.Parse(fila["desdebarrio"].ToString()));
                    string hastaBarrio = oBarrio.nombreBarrio(int.Parse(fila["hastabarrio"].ToString()));
                    DateTime fecha = Convert.ToDateTime(fila["fecha"].ToString());
                    dataGridView1.Rows.Add(fecha.ToString("dd/MM/yyyy"), desdeBarrio, hastaBarrio, fila["km"], fila["importe"]);
                }
            }
        }
    }
}
