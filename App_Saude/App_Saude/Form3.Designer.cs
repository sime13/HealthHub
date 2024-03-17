namespace App_Saude
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Peso = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.Idade = new System.Windows.Forms.TextBox();
            this.Pesolab = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Alturalab = new System.Windows.Forms.Label();
            this.Reusutado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.Limpar = new System.Windows.Forms.Button();
            this.Exibicao = new System.Windows.Forms.Label();
            this.Exibicao2 = new System.Windows.Forms.Label();
            this.Exibicao1 = new System.Windows.Forms.Label();
            this.Exibicao3 = new System.Windows.Forms.Label();
            this.Exibicao4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Peso
            // 
            this.Peso.Location = new System.Drawing.Point(55, 91);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(152, 20);
            this.Peso.TabIndex = 1;
            // 
            // Altura
            // 
            this.Altura.Location = new System.Drawing.Point(55, 145);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(152, 20);
            this.Altura.TabIndex = 2;
            this.Altura.Text = "0";
            // 
            // Idade
            // 
            this.Idade.Location = new System.Drawing.Point(55, 209);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(152, 20);
            this.Idade.TabIndex = 3;
            // 
            // Pesolab
            // 
            this.Pesolab.AutoSize = true;
            this.Pesolab.Location = new System.Drawing.Point(52, 72);
            this.Pesolab.Name = "Pesolab";
            this.Pesolab.Size = new System.Drawing.Size(31, 13);
            this.Pesolab.TabIndex = 4;
            this.Pesolab.Text = "Peso";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(55, 185);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(34, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Idade";
            // 
            // Alturalab
            // 
            this.Alturalab.AutoSize = true;
            this.Alturalab.Location = new System.Drawing.Point(55, 124);
            this.Alturalab.Name = "Alturalab";
            this.Alturalab.Size = new System.Drawing.Size(34, 13);
            this.Alturalab.TabIndex = 6;
            this.Alturalab.Text = "Altura";
            // 
            // Reusutado
            // 
            this.Reusutado.AutoSize = true;
            this.Reusutado.Location = new System.Drawing.Point(380, 40);
            this.Reusutado.Name = "Reusutado";
            this.Reusutado.Size = new System.Drawing.Size(52, 13);
            this.Reusutado.TabIndex = 7;
            this.Reusutado.Text = "Seu TMB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sexo";
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(62, 268);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 9;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(63, 292);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(67, 17);
            this.Feminino.TabIndex = 10;
            this.Feminino.TabStop = true;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(213, 332);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(88, 39);
            this.Limpar.TabIndex = 11;
            this.Limpar.Text = "Limpar";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Exibicao
            // 
            this.Exibicao.AutoSize = true;
            this.Exibicao.Location = new System.Drawing.Point(380, 110);
            this.Exibicao.MaximumSize = new System.Drawing.Size(1250, 1500);
            this.Exibicao.MinimumSize = new System.Drawing.Size(25, 15);
            this.Exibicao.Name = "Exibicao";
            this.Exibicao.Size = new System.Drawing.Size(25, 15);
            this.Exibicao.TabIndex = 12;
            this.Exibicao.Text = "..";
            // 
            // Exibicao2
            // 
            this.Exibicao2.AutoSize = true;
            this.Exibicao2.Location = new System.Drawing.Point(380, 185);
            this.Exibicao2.MaximumSize = new System.Drawing.Size(1250, 1500);
            this.Exibicao2.MinimumSize = new System.Drawing.Size(25, 15);
            this.Exibicao2.Name = "Exibicao2";
            this.Exibicao2.Size = new System.Drawing.Size(25, 15);
            this.Exibicao2.TabIndex = 13;
            this.Exibicao2.Text = "..";
            // 
            // Exibicao1
            // 
            this.Exibicao1.AutoSize = true;
            this.Exibicao1.Location = new System.Drawing.Point(380, 145);
            this.Exibicao1.MaximumSize = new System.Drawing.Size(1250, 1500);
            this.Exibicao1.MinimumSize = new System.Drawing.Size(25, 15);
            this.Exibicao1.Name = "Exibicao1";
            this.Exibicao1.Size = new System.Drawing.Size(25, 15);
            this.Exibicao1.TabIndex = 14;
            this.Exibicao1.Text = "..";
            // 
            // Exibicao3
            // 
            this.Exibicao3.AutoSize = true;
            this.Exibicao3.Location = new System.Drawing.Point(380, 214);
            this.Exibicao3.MaximumSize = new System.Drawing.Size(1250, 1500);
            this.Exibicao3.MinimumSize = new System.Drawing.Size(25, 15);
            this.Exibicao3.Name = "Exibicao3";
            this.Exibicao3.Size = new System.Drawing.Size(25, 15);
            this.Exibicao3.TabIndex = 15;
            this.Exibicao3.Text = "..";
            // 
            // Exibicao4
            // 
            this.Exibicao4.AutoSize = true;
            this.Exibicao4.Location = new System.Drawing.Point(380, 244);
            this.Exibicao4.MaximumSize = new System.Drawing.Size(1250, 1500);
            this.Exibicao4.MinimumSize = new System.Drawing.Size(25, 15);
            this.Exibicao4.Name = "Exibicao4";
            this.Exibicao4.Size = new System.Drawing.Size(25, 15);
            this.Exibicao4.TabIndex = 16;
            this.Exibicao4.Text = "..";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exibicao4);
            this.Controls.Add(this.Exibicao3);
            this.Controls.Add(this.Exibicao1);
            this.Controls.Add(this.Exibicao2);
            this.Controls.Add(this.Exibicao);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Feminino);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reusutado);
            this.Controls.Add(this.Alturalab);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Pesolab);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.TextBox Idade;
        private System.Windows.Forms.Label Pesolab;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Alturalab;
        private System.Windows.Forms.Label Reusutado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label Exibicao;
        private System.Windows.Forms.Label Exibicao2;
        private System.Windows.Forms.Label Exibicao1;
        private System.Windows.Forms.Label Exibicao3;
        private System.Windows.Forms.Label Exibicao4;
    }
}