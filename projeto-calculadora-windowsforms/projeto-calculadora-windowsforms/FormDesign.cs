using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_calculadora_windowsforms
{
    public partial class FormDesign : Form  
    {
        public FormDesign()
        {
            InitializeComponent();
        }
        double nu1, nu2, resul;
        private void butSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butLimpar_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textResul.Text = "";
        }

        private void butIMC_Click(object sender, EventArgs e)
        {
            FormIMC novo = new FormIMC();
            novo.Show();
            this.Visible = false;
        }

        private void butSoma_Click(object sender, EventArgs e)
        {
            nu1 = Convert.ToDouble(textNum1.Text);
            nu2 = Convert.ToDouble(textNum2.Text);
            resul = nu1 + nu2;
            textResul.Text = resul.ToString();
        }

        private void butDividir_Click(object sender, EventArgs e)
        {
            nu1 = Convert.ToDouble(textNum1.Text);
            nu2 = Convert.ToDouble(textNum2.Text);
            resul = nu1 / nu2;
            textResul.Text = resul.ToString();
        }

        private void textResul_TextChanged(object sender, EventArgs e)
        {

        }

        private void butVezes_Click(object sender, EventArgs e)
        {
            nu1 = Convert.ToDouble(textNum1.Text);
            nu2 = Convert.ToDouble(textNum2.Text);
            resul = nu1 * nu2;
            textResul.Text = resul.ToString();
        }

        

        private void butMenos_Click(object sender, EventArgs e)
        {
            nu1 = Convert.ToDouble(textNum1.Text);
            nu2 = Convert.ToDouble(textNum2.Text);
            resul = nu1 - nu2;
            textResul.Text = resul.ToString();
        }
    }
}
