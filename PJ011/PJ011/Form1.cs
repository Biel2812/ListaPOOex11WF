using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ011
{
    public partial class frmindice : Form
    {
        public frmindice()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            Indice i;
            i = new Indice();
            i.setVpeso(int.Parse(txtpeso.Text));
            i.setValtura(int.Parse(txtaltura.Text));
            i.calcularValores();

            lblResultado.Text = i.getValores().ToString();
        }
    }
}
