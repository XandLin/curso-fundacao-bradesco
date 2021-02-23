
namespace projeto_calculadora_windowsforms_teste
{
    partial class FormDesign
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.butDividir = new System.Windows.Forms.Button();
            this.butSoma = new System.Windows.Forms.Button();
            this.butVezes = new System.Windows.Forms.Button();
            this.butMenos = new System.Windows.Forms.Button();
            this.butLimpar = new System.Windows.Forms.Button();
            this.butIMC = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butDividir
            // 
            this.butDividir.Location = new System.Drawing.Point(25, 165);
            this.butDividir.Name = "butDividir";
            this.butDividir.Size = new System.Drawing.Size(75, 30);
            this.butDividir.TabIndex = 0;
            this.butDividir.Text = "/";
            this.butDividir.UseVisualStyleBackColor = true;
            this.butDividir.Click += new System.EventHandler(this.butDividir_Click);
            // 
            // butSoma
            // 
            this.butSoma.Location = new System.Drawing.Point(25, 195);
            this.butSoma.Name = "butSoma";
            this.butSoma.Size = new System.Drawing.Size(75, 30);
            this.butSoma.TabIndex = 1;
            this.butSoma.Text = "+";
            this.butSoma.UseVisualStyleBackColor = true;
            this.butSoma.Click += new System.EventHandler(this.butSoma_Click);
            // 
            // butVezes
            // 
            this.butVezes.Location = new System.Drawing.Point(100, 165);
            this.butVezes.Name = "butVezes";
            this.butVezes.Size = new System.Drawing.Size(75, 30);
            this.butVezes.TabIndex = 2;
            this.butVezes.Text = "*";
            this.butVezes.UseVisualStyleBackColor = true;
            this.butVezes.Click += new System.EventHandler(this.butVezes_Click);
            // 
            // butMenos
            // 
            this.butMenos.Location = new System.Drawing.Point(100, 195);
            this.butMenos.Name = "butMenos";
            this.butMenos.Size = new System.Drawing.Size(75, 30);
            this.butMenos.TabIndex = 3;
            this.butMenos.Text = "-";
            this.butMenos.UseVisualStyleBackColor = true;
            this.butMenos.Click += new System.EventHandler(this.butMenos_Click);
            // 
            // butLimpar
            // 
            this.butLimpar.Location = new System.Drawing.Point(185, 165);
            this.butLimpar.Name = "butLimpar";
            this.butLimpar.Size = new System.Drawing.Size(75, 30);
            this.butLimpar.TabIndex = 4;
            this.butLimpar.Text = "Limpar";
            this.butLimpar.UseVisualStyleBackColor = true;
            this.butLimpar.Click += new System.EventHandler(this.butLimpar_Click);
            // 
            // butIMC
            // 
            this.butIMC.Location = new System.Drawing.Point(185, 195);
            this.butIMC.Name = "butIMC";
            this.butIMC.Size = new System.Drawing.Size(75, 30);
            this.butIMC.TabIndex = 5;
            this.butIMC.Text = "IMC";
            this.butIMC.UseVisualStyleBackColor = true;
            this.butIMC.Click += new System.EventHandler(this.butIMC_Click);
            // 
            // butSair
            // 
            this.butSair.Location = new System.Drawing.Point(100, 300);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(75, 30);
            this.butSair.TabIndex = 6;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.butSair_Click);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(63, 62);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(151, 20);
            this.textNum1.TabIndex = 7;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(63, 88);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(151, 20);
            this.textNum2.TabIndex = 8;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(63, 258);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(151, 20);
            this.textResult.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculadora";
            // 
            // FormDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butIMC);
            this.Controls.Add(this.butLimpar);
            this.Controls.Add(this.butMenos);
            this.Controls.Add(this.butVezes);
            this.Controls.Add(this.butSoma);
            this.Controls.Add(this.butDividir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDesign";
            this.Text = "Calculadora Básica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDividir;
        private System.Windows.Forms.Button butSoma;
        private System.Windows.Forms.Button butVezes;
        private System.Windows.Forms.Button butMenos;
        private System.Windows.Forms.Button butLimpar;
        private System.Windows.Forms.Button butIMC;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label1;
    }
}

