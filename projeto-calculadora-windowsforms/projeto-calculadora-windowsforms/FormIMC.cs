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
    public partial class FormIMC : Form
    {
        double altura, kilo, resul, aux;
        public FormIMC()
        {
            InitializeComponent();
        }

        private void butSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void butVolta_Click(object sender, EventArgs e)
        {
            FormDesign novo = new FormDesign();
            novo.Show();
            this.Visible = false;
        }

        private void FormIMC_Load(object sender, EventArgs e)
        {   
            int cont, cont2 = 100;
            cont2 = 100;
            for (cont = 50; cont <=300; cont++)
            {
                comboKilo.Items.Add(cont);
                if (cont2 <= 210)
                {
                    comboAltura.Items.Add(cont2);
                    cont2++;
                }
            }
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            aux = Convert.ToDouble(comboAltura.Text);
            kilo = Convert.ToDouble(comboKilo.Text);
            altura = aux / 100;
            resul = kilo / (altura * altura);
            textResult.Text = resul.ToString("N2");

            if (resul < 18.5)
            {
                textDiscricao.Text = ("Abaixo do Peso");
            }
            else if (resul >= 18.5 && resul <= 24.9)
            {
                textDiscricao.Text = ("Normal");
            }
            else if (resul >= 25 && resul <= 29.9)
            {
                textDiscricao.Text = ("Sobrepeso");
            }
            else if (resul >= 30 && resul <= 39.9)
            {
                textDiscricao.Text = ("Obesidade");
            }
            else
            {
                textDiscricao.Text = ("Obesidade Grave");
            }
        }

        private void comboKilo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            aux = Convert.ToDouble(comboAltura.Text);
            kilo = Convert.ToDouble(comboKilo.Text);
            altura = aux / 100;
            resul = kilo/(altura * altura) ;
            textResult.Text = resul.ToString("N2");

            if (resul < 18.5)
            {
                textDiscricao.Text = ("Abaixo do Peso");
            }
            else if (resul >= 18.5 && resul <= 24.9)
            {
                textDiscricao.Text = ("Normal");
            }
            else if (resul >= 25 && resul <= 29.9)
            {
                textDiscricao.Text = ("Sobrepeso");
            }
            else if (resul >= 30 && resul <= 39.9)
            {
                textDiscricao.Text = ("Obesidade");
            }
            else
            {
                textDiscricao.Text = ("Obesidade Grave");
            }
        }

       

        private void comboAltura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textDiscricao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
