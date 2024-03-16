namespace App_Saude
{
    partial class Form2
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
            this.Calcular = new System.Windows.Forms.Button();
            this.Peso = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(288, 209);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(148, 24);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Peso
            // 
            this.Peso.AcceptsReturn = true;
            this.Peso.AcceptsTab = true;
            this.Peso.Location = new System.Drawing.Point(288, 90);
            this.Peso.Name = "Peso";
            this.Peso.Size = new System.Drawing.Size(148, 20);
            this.Peso.TabIndex = 1;
            // 
            // Altura
            // 
            this.Altura.AcceptsReturn = true;
            this.Altura.Location = new System.Drawing.Point(288, 151);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(148, 20);
            this.Altura.TabIndex = 2;
            // 
            // Resultado
            // 
            this.Resultado.AcceptsTab = true;
            this.Resultado.Location = new System.Drawing.Point(189, 259);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(357, 96);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altura";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Peso);
            this.Controls.Add(this.Calcular);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox Peso;
        private System.Windows.Forms.TextBox Altura;
        private System.Windows.Forms.RichTextBox Resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}