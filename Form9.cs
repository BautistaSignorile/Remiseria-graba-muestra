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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        Viajes oViajes;
        DataTable tViajes;
        Chofer oChofer;
        DataTable tChofer;
        private void Form9_Load(object sender, EventArgs e)
        {
            oChofer = new Chofer();
            tChofer = oChofer.GetDataChofer();
            int cantidadViajes = 0;
            oViajes = new Viajes();
            tViajes = oViajes.GetDataViajes();

            List<DateTime> fecha = new List<DateTime>();

            foreach (DataRow fila in tViajes.Rows)
            {
                if (!fecha.Contains(Convert.ToDateTime(fila["fecha"])))
                {
                    fecha.Add(Convert.ToDateTime(fila["fecha"]));
                }
            }
            for (int i = 0; i < fecha.Count; i++)
            {
                comboBox1.Items.Add(fecha[i]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cantidachoferes = 0;
            int filas = tChofer.Rows.Count;
            decimal[,] matrizDatos = new decimal[filas, 2];
            int f = 0;
            foreach (DataRow fila in tChofer.Rows)
            {
                matrizDatos[f, 0] = Convert.ToDecimal(fila["chofer"]);
                matrizDatos[f, 1] = 0;
                f++;
            }
            for (int i = 0; i < matrizDatos.GetLength(0); i++)
            {
                foreach (DataRow fila in tViajes.Rows)
                {
                    if (comboBox1.SelectedItem.ToString() == fila["fecha"].ToString())
                    {
                        if (matrizDatos[i, 0] == Convert.ToInt32(fila["chofer"]))
                        {
                            matrizDatos[i, 1] += Convert.ToDecimal(fila["importe"].ToString());
                        }
                    }
                }
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < matrizDatos.GetLength(0); i++)
            {
                if (matrizDatos[i, 1] != 0)
                {
                    string nombre = oChofer.getNombre(int.Parse(matrizDatos[i, 0].ToString()));
                    dataGridView1.Rows.Add(nombre, matrizDatos[i, 1]);
                }
            }
        }
    }
}