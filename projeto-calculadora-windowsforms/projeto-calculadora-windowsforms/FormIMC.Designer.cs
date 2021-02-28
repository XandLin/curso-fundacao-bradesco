
namespace projeto_calculadora_windowsforms
{
    partial class FormIMC
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
            this.butVolta = new System.Windows.Forms.Button();
            this.butSair = new System.Windows.Forms.Button();
            this.comboKilo = new System.Windows.Forms.ComboBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboAltura = new System.Windows.Forms.ComboBox();
            this.textDiscricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butVolta
            // 
            this.butVolta.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butVolta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVolta.ForeColor = System.Drawing.Color.DarkOrange;
            this.butVolta.Location = new System.Drawing.Point(20, 350);
            this.butVolta.Name = "butVolta";
            this.butVolta.Size = new System.Drawing.Size(75, 30);
            this.butVolta.TabIndex = 1;
            this.butVolta.Text = "<";
            this.butVolta.UseVisualStyleBackColor = true;
            this.butVolta.Click += new System.EventHandler(this.butVolta_Click);
            // 
            // butSair
            // 
            this.butSair.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.botao;
            this.butSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSair.ForeColor = System.Drawing.Color.DarkOrange;
            this.butSair.Location = new System.Drawing.Point(100, 350);
            this.butSair.Name = "butSair";
            this.butSair.Size = new System.Drawing.Size(75, 30);
            this.butSair.TabIndex = 2;
            this.butSair.Text = "Sair";
            this.butSair.UseVisualStyleBackColor = true;
            this.butSair.Click += new System.EventHandler(this.butSair_Click);
            // 
            // comboKilo
            // 
            this.comboKilo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKilo.ForeColor = System.Drawing.Color.DarkOrange;
            this.comboKilo.FormattingEnabled = true;
            this.comboKilo.Items.AddRange(new object[] {
            ""});
            this.comboKilo.Location = new System.Drawing.Point(81, 178);
            this.comboKilo.Name = "comboKilo";
            this.comboKilo.Size = new System.Drawing.Size(129, 24);
            this.comboKilo.TabIndex = 4;
            this.comboKilo.SelectedIndexChanged += new System.EventHandler(this.comboKilo_SelectedIndexChanged);
            // 
            // textResult
            // 
            this.textResult.ForeColor = System.Drawing.Color.DarkOrange;
            this.textResult.Location = new System.Drawing.Point(35, 260);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(45, 20);
            this.textResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Altura(cm):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(33, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Peso(Kg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(100, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label4.Location = new System.Drawing.Point(114, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "IMC";
            // 
            // comboAltura
            // 
            this.comboAltura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAltura.ForeColor = System.Drawing.Color.DarkOrange;
            this.comboAltura.FormattingEnabled = true;
            this.comboAltura.Items.AddRange(new object[] {
            ""});
            this.comboAltura.Location = new System.Drawing.Point(81, 106);
            this.comboAltura.Name = "comboAltura";
            this.comboAltura.Size = new System.Drawing.Size(129, 24);
            this.comboAltura.TabIndex = 16;
            this.comboAltura.SelectedIndexChanged += new System.EventHandler(this.comboAltura_SelectedIndexChanged);
            // 
            // textDiscricao
            // 
            this.textDiscricao.ForeColor = System.Drawing.Color.DarkOrange;
            this.textDiscricao.Location = new System.Drawing.Point(80, 280);
            this.textDiscricao.Multiline = true;
            this.textDiscricao.Name = "textDiscricao";
            this.textDiscricao.Size = new System.Drawing.Size(130, 60);
            this.textDiscricao.TabIndex = 17;
            // 
            // FormIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto_calculadora_windowsforms.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.textDiscricao);
            this.Controls.Add(this.comboAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.comboKilo);
            this.Controls.Add(this.butSair);
            this.Controls.Add(this.butVolta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormIMC";
            this.Text = "IMC (Índice de massa corporal)";
            this.Load += new System.EventHandler(this.FormIMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butVolta;
        private System.Windows.Forms.Button butSair;
        private System.Windows.Forms.ComboBox comboKilo;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboAltura;
        private System.Windows.Forms.TextBox textDiscricao;
    }
}