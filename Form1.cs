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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tabla;
        DataRow datos;
        private void Form1_Load(object sender, EventArgs e)
        {
            remiseria oremiseria = new remiseria();
            tabla = oremiseria.GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos = tabla.Rows.Find(Convert.ToInt32(textBox1.Text));
            textBox2.Text = datos["nombre"].ToString();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            datos["chofer"] = Convert.ToInt32(textBox1.Text);
            datos["nombre"] = textBox2.Text;
        }
    }
}
