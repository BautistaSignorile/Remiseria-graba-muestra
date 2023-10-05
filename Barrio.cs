using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria
{
    internal class Barrio
    {
        OleDbCommand comando;
        OleDbConnection conector;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        public Barrio()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=REMISYA.mdb");
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Barrios";

            adaptador.Fill(tabla);

            DataColumn[] vec = new DataColumn[1];
            vec[0] = tabla.Columns["barrio"];
            tabla.PrimaryKey = vec;
        }
        public string nombreBarrio(int numeroBarrio)
        {
            DataRow fila = tabla.Rows.Find(numeroBarrio);
            return fila["nombre"].ToString();

        }
        public int[] devolverBarrio()
        {
            int[] barrios = new int[11];
            int i = 0;
            foreach (DataRow fila in tabla.Rows)
            {
                barrios[i] = int.Parse(fila["barrio"].ToString());
                i++;
            }
            return barrios;
        }

        public DataTable GetDataBarrio()
        {
            return tabla;
        }

        public bool grabar(int barrio, string nombre)
        {
            bool ok = true;

            DataRow filaBuscada = tabla.Rows.Find(barrio);
            if (filaBuscada == null)
            {
                foreach (DataRow fbar in tabla.Rows)
                {
                    if (fbar["nombre"].ToString() == nombre)
                    {
                        ok = false;
                    }
                }
                if(ok = true)
                {
                    DataRow fila = tabla.NewRow();
                    fila["barrio"] = barrio;
                    fila["nombre"] = nombre;
                    tabla.Rows.Add(fila);

                    OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
                    adaptador.Update(tabla);
                }
            }
            else
            {
                ok = false;
            }
            return ok;
        }
    }
}
