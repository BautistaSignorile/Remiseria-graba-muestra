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
    public partial class Form7 : Form
    {
        Viajes oviajes;
        DataTable tviajes;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            oviajes = new Viajes();
            tviajes = oviajes.GetData();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int viaje = int.Parse(textBox1.Text);
                DataRow fila = tviajes.Rows.Find(viaje);
                if (fila != null)
                {
                    DateTime fecha = Convert.ToDateTime(fila["fecha"].ToString());
                    dateTimePicker1.Value = fecha;
                    textBox2.Text = fila["km"].ToString();
                    textBox3.Text = fila["importe"].ToString();
                }
                else
                {
                    MessageBox.Show("El viaje no existe", "AVISO");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero entero", "AVISO");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int viaje = int.Parse(textBox1.Text);
            oviajes.eliminarViaje(viaje);
        }
    }
}
