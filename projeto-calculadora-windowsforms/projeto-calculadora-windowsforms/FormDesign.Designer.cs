
namespace projeto_calculadora_windowsforms
{
    partial class FormDesign
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butMenos = new System.Windows.Forms.Button();
            this.butVezes = new System.Windows.Forms.Button();
            this.butDividir = new System.Windows.Forms.Button();
            this.butIMC = new System.Windows.Forms.Button();
            this.butLimpar = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.textResul = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butSoma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butMenos
            // 
            this.butMenos.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butMenos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMenos.ForeColor = System.Drawing.Color.DarkOrange;
            this.butMenos.Location = new System.Drawing.Point(100, 170);
            this.butMenos.Name = "butMenos";
            this.butMenos.Size = new System.Drawing.Size(75, 30);
            this.butMenos.TabIndex = 3;
            this.butMenos.Text = "─";
            this.butMenos.UseVisualStyleBackColor = true;
            this.butMenos.Click += new System.EventHandler(this.butMenos_Click);
            // 
            // butVezes
            // 
            this.butVezes.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butVezes.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVezes.ForeColor = System.Drawing.Color.DarkOrange;
            this.butVezes.Location = new System.Drawing.Point(100, 200);
            this.butVezes.Name = "butVezes";
            this.butVezes.Size = new System.Drawing.Size(75, 30);
            this.butVezes.TabIndex = 4;
            this.butVezes.Text = "×";
            this.butVezes.UseVisualStyleBackColor = true;
            this.butVezes.Click += new System.EventHandler(this.butVezes_Click);
            // 
            // butDividir
            // 
            this.butDividir.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butDividir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDividir.ForeColor = System.Drawing.Color.DarkOrange;
            this.butDividir.Location = new System.Drawing.Point(20, 200);
            this.butDividir.Name = "butDividir";
            this.butDividir.Size = new System.Drawing.Size(75, 30);
            this.butDividir.TabIndex = 6;
            this.butDividir.Text = "÷";
            this.butDividir.UseVisualStyleBackColor = true;
            this.butDividir.Click += new System.EventHandler(this.butDividir_Click);
            // 
            // butIMC
            // 
            this.butIMC.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butIMC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butIMC.ForeColor = System.Drawing.Color.DarkOrange;
            this.butIMC.Location = new System.Drawing.Point(195, 200);
            this.butIMC.Name = "butIMC";
            this.butIMC.Size = new System.Drawing.Size(75, 30);
            this.butIMC.TabIndex = 2;
            this.butIMC.Text = "IMC";
            this.butIMC.UseVisualStyleBackColor = true;
            this.butIMC.Click += new System.EventHandler(this.butIMC_Click);
            // 
            // butLimpar
            // 
            this.butLimpar.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLimpar.ForeColor = System.Drawing.Color.DarkOrange;
            this.butLimpar.Location = new System.Drawing.Point(195, 170);
            this.butLimpar.Name = "butLimpar";
            this.butLimpar.Size = new System.Drawing.Size(75, 30);
            this.butLimpar.TabIndex = 1;
            this.butLimpar.Text = "Limpar";
            this.butLimpar.UseVisualStyleBackColor = true;
            this.butLimpar.Click += new System.EventHandler(this.butLimpar_Click);
            // 
            // butSair
            // 
            this.butSair.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSair.ForeColor = System.Drawing.Color.DarkOrange;
            this.butSair.Location = new System.Drawing.Point(100, 350);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(75, 30);
            this.butSair.TabIndex = 0;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.butSair_Click);
            // 
            // textResul
            // 
            this.textResul.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResul.ForeColor = System.Drawing.Color.DarkOrange;
            this.textResul.Location = new System.Drawing.Point(64, 286);
            this.textResul.Name = "textResul";
            this.textResul.Size = new System.Drawing.Size(149, 22);
            this.textResul.TabIndex = 7;
            this.textResul.TextChanged += new System.EventHandler(this.textResul_TextChanged);
            // 
            // textNum2
            // 
            this.textNum2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum2.ForeColor = System.Drawing.Color.DarkOrange;
            this.textNum2.Location = new System.Drawing.Point(64, 135);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(149, 22);
            this.textNum2.TabIndex = 8;
            // 
            // textNum1
            // 
            this.textNum1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum1.ForeColor = System.Drawing.Color.DarkOrange;
            this.textNum1.Location = new System.Drawing.Point(64, 89);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(149, 22);
            this.textNum1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculadora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resultado:";
            // 
            // butSoma
            // 
            this.butSoma.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butSoma.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSoma.ForeColor = System.Drawing.Color.DarkOrange;
            this.butSoma.Location = new System.Drawing.Point(20, 170);
            this.butSoma.Name = "butSoma";
            this.butSoma.Size = new System.Drawing.Size(75, 30);
            this.butSoma.TabIndex = 12;
            this.butSoma.Text = "+";
            this.butSoma.UseVisualStyleBackColor = true;
            this.butSoma.Click += new System.EventHandler(this.butSoma_Click);
            // 
            // FormDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.butSoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textResul);
            this.Controls.Add(this.butDividir);
            this.Controls.Add(this.butVezes);
            this.Controls.Add(this.butMenos);
            this.Controls.Add(this.butIMC);
            this.Controls.Add(this.butLimpar);
            this.Controls.Add(this.butSair);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDesign";
            this.Text = "Calculadora Basica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.Button butLimpar;
        private System.Windows.Forms.Button butIMC;
        private System.Windows.Forms.Button butMenos;
        private System.Windows.Forms.Button butVezes;
        private System.Windows.Forms.Button butDividir;
        private System.Windows.Forms.TextBox textResul;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butSoma;
    }
}