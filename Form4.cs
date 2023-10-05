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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        

        private void Form4_Load(object sender, EventArgs e)
        {
            Chofer chofer = new Chofer();
            Viajes Viajes = new Viajes();
            DataTable tChofer = chofer.GetDataChofer();
            DataTable tViaje = Viajes.GetDataViajes();

            foreach (DataRow filaChofer in tChofer.Rows)
            {
                decimal recaudacion = 0;
                foreach (DataRow filaViaje in tViaje.Rows)
                {
                    if (filaChofer["chofer"].ToString() == filaViaje["chofer"].ToString());
                    {
                        recaudacion += Convert.ToDecimal(filaViaje["Importe"]);
                    }
                }
                dataGridView1.Rows.Add(filaChofer["nombre"], recaudacion);
            }
        }
    }
}
