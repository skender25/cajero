using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            int consulta;
            int  dos, cinco, diez;
            int bitacora = 0;
            int contador = 0;

            string coti = "";

            

                consulta = Convert.ToInt32(txtmonto.Text);
            contador = contador + consulta;

            if ( consulta % 5==0 )
                {
                    diez = consulta / 10000;
                consulta = consulta % 10000;
         coti+=" Son " + diez + "     billetes de 10 000   \r\n";

                cinco = consulta / 5000;
                consulta = consulta % 5000;
                    coti+= " Son " + cinco + "   billetes de 5000 \r\n";
                dos = consulta / 2000;
                consulta = consulta % 2000;
                    coti+= " Son " + dos + "   billetes de 2000 \r\n"; 

                bitacora+=contador;
                txtbit.Text = Convert.ToString(bitacora);

            }

                MessageBox.Show(coti);
            

        }
          

            
        }
    }

