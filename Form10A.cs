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
    public partial class Form10A : Form
    {
        Viajes oviaje;
        DataTable tviaje;
        Chofer ochofer;
        DataTable tchofer;
        Barrio obarrio;
        DataTable tbarrio;
        public Form10A()
        {
            InitializeComponent();
        }

        private void Form10A_Load(object sender, EventArgs e)
        {
            oviaje = new Viajes();
            tviaje = oviaje.GetDataViajes();
            obarrio = new Barrio();
            tbarrio = obarrio.GetDataBarrio();
            ochofer = new Chofer();
            tchofer = ochofer.GetDataChofer();

            CbChofer.DisplayMember = "nombre";
            CbChofer.ValueMember = "chofer";
            CbChofer.DataSource = tchofer;
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            int AA = 0;
            int MM = 0;

            DateTime fecha;
            Decimal total = 0;

            DataRow Fbarrio;

            string BARRIO1 = "";
            string BARRIO2 = "";

            datagridview1.Rows.Clear();
            foreach(DataRow FViaje in tviaje.Rows)
            {
                fecha = Convert.ToDateTime(FViaje["fecha"]);
                AA = fecha.Year;
                MM = fecha.Month;

                if (AA.ToString() == TxtAa.Text && MM == CbMes.SelectedIndex+1 && FViaje["chofer"].ToString() == CbChofer.SelectedValue.ToString())
                {
                    Fbarrio = tbarrio.Rows.Find(FViaje["desdebarrio"]);
                    BARRIO1 = Fbarrio["nombre"].ToString();

                    Fbarrio = tbarrio.Rows.Find(FViaje["hastabarrio"]);
                    BARRIO2 = Fbarrio["nombre"].ToString();

                    datagridview1.Rows.Add(FViaje["fecha"], BARRIO1, BARRIO2, FViaje["km"], FViaje["importe"]);
                    total = total + Convert.ToDecimal(FViaje["importe"]);
                }
                LblTotal.Text = total.ToString("###,###,##0.00");
            }
        }
    }
}
