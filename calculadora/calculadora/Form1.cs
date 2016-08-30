using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void calculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            bool tieneSuma = tbxResultado.Text.Contains("+");

            if (tieneSuma)
            {

                string[] values = tbxResultado.Text.Split('+');
                string val1 = values[0];
                string val2 = values[1];

                Calproceso metodoSuma = new Calproceso(val1,val2);
                tbxResultado.Text = metodoSuma.sumar();

            }

            bool tieneResta = tbxResultado.Text.Contains("-");

            if (tieneResta)
            {

                string[] values = tbxResultado.Text.Split('-');
                string val1 = values[0];
                string val2 = values[1];

                Calproceso metodoResta = new Calproceso(val1, val2);
                tbxResultado.Text = metodoResta.resta();

            }

            bool tieneDividir = tbxResultado.Text.Contains("/");

            if (tieneDividir)
            {

                string[] values = tbxResultado.Text.Split('/');
                string val1 = values[0];
                string val2 = values[1];

                Calproceso metodoDividir = new Calproceso(val1, val2);
                tbxResultado.Text = metodoDividir.dividir();

            }

            bool tieneMultiplicar = tbxResultado.Text.Contains("*");

            if (tieneMultiplicar)
            {

                string[] values = tbxResultado.Text.Split('*');
                string val1 = values[0];
                string val2 = values[1];

                Calproceso metodoMultiplicar = new Calproceso(val1, val2);
                tbxResultado.Text = metodoMultiplicar.multiplicacion();

            }
        }

        private void tbxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "3";
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "6";
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "7";
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "8";
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "9";
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "0";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "+";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            tbxResultado.Text = tbxResultado.Text + "/";
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBorraall_Click(object sender, EventArgs e)
        {
            int hasta = tbxResultado.Text.Length - 1;
            string resultado = tbxResultado.Text.Substring(0, hasta);
            tbxResultado.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int hasta = tbxResultado.Text.Length - 1;            
            string resultado = tbxResultado.Text.Substring(0, hasta);
            tbxResultado.Text= resultado;

        }
    }
}
