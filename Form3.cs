using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Remiseria
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Chofer Ochofer;
        Viajes viaje; 
        DataTable tviaje;
        DataRow datos;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            viaje = new Viajes();
            tviaje = viaje.GetData();
            Ochofer = new Chofer();
              
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DateTime Desde = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime Hasta = Convert.ToDateTime(dateTimePicker2.Text);

            foreach (DataRow datos in tviaje.Rows)
            {
                if (Convert.ToDateTime(datos["fecha"]) >= Desde && Convert.ToDateTime(datos["fecha"]) <= Hasta)
                {
                    string chofer = Ochofer.getNombre(int.Parse(datos["chofer"].ToString()));
                    DateTime fecha = Convert.ToDateTime(datos["fecha"]);
                    dataGridView1.Rows.Add(datos["viaje"], fecha.ToString("dd/MM/yyyy"), chofer, datos["importe"]);
                }
            }

        }
    }
}
