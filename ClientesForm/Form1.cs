using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesForm
{
    public partial class Form1 : Form
    { 
         double cm;
         double cf;
         bool primero = true;
         claseCliente MasViejo;
        public Form1()
        {
            InitializeComponent();
            cm = 0;
            cf = 0;
            MasViejo = null;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            claseCliente c;
            c = new claseCliente();
            c.pCodigo = Convert.ToInt32(txtCod.Text);
            c.pNombre = txtNombre.Text;
            c.pTipoDoc = cboTipoDoc.SelectedIndex + 1;
            c.pdocumento = Convert.ToInt32(txtDocumento.Text);
            c.pFechaNac = dtpFechaNac.Value;
            c.pSexo = rbtMasc.Checked;
            c.pEsCasado = chkCasado.Checked;

            MessageBox.Show(c.toString());

            if(c.pSexo)
              cm++;

             else
             cf++;

            lblVarones.Text = cm.ToString();
            lblMujeres.Text = cf.ToString();

            lblPorcVaron.Text =Convert.ToString (cm / (cm + cf) * 100);
            lblPorcMujer.Text =Convert.ToString (cf / (cf + cm )* 100);

            lblEdad.Text = c.calcularEdad().ToString();

            
            if(primero)
            {
                lblMayorEdad.Text = c.calcularEdad() + c.pNombre;
                MasViejo=c;
                primero = false;
            }
            else
                if(c.calcularEdad() > MasViejo.calcularEdad())
                {
                    lblMayorEdad.Text = c.calcularEdad() + " " + c.pNombre;
                    MasViejo = c;
                }
        }
    }
}
