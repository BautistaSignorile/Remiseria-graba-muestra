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
        DataTable tviaje;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Viajes oviaje = new Viajes();
            tviaje = oviaje.GetData();
        }
    }
}
