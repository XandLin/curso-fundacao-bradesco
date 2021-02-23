using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_calculadora_windowsforms_teste
{
    public partial class FormDesign : Form
    {
        double nu1, nu2, resul;

        public FormDesign()
        {
            InitializeComponent();
        }

        private void butSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butLimpar_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
        }

        private void butSoma_Click(object sender, EventArgs e)
        {
            nu1 = Convert.ToDouble(textNum1.Text);
            nu2 = Convert.ToDouble(textNum2.Text);
            resul = nu1 + nu2;
            textResult.Text = resul.ToString();
        }

        private void butMenos_Click(object sender, EventArgs e)
        {
            nu1 = Convert.ToDouble(textNum1.Text);
            nu2 = Convert.ToDouble(textNum2.Text);
            resul = nu1 - nu2;
            textResult.Text = resul.ToString();
        }

        private void butIMC_Click(object sender, EventArgs e)
        {
            FormIMC novo = new FormIMC();
            novo.Show();
            this.Visible = false;
        }

        private void butDividir_Click(object sender, EventArgs e)
        {
            nu1 = Convert.ToDouble(textNum1.Text);
            nu2 = Convert.ToDouble(textNum2.Text);
            resul = nu1 / nu2;
            textResult.Text = resul.ToString();
        }

        private void butVezes_Click(object sender, EventArgs e)
        {
            nu1 = Convert.ToDouble(textNum1.Text);
            nu2 = Convert.ToDouble(textNum2.Text);
            resul = nu1 * nu2;
            textResult.Text = resul.ToString();

        }
    }
}
