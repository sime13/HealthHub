using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace App_Saude
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Peso.Text, out double peso) &&
                double.TryParse(Altura.Text, out double altura) &&
                int.TryParse(Idade.Text, out int idade))
            {
                // Cálculo da TMB para homens e mulheres
                decimal tmbMasculino = 88.362m + (13.397m * (decimal)peso) + (4.799m * (decimal)altura) - (5.677m * idade);
                
                decimal tmbFeminino = 447.593m + (9.247m * (decimal)peso) + (3.098m * (decimal)altura) - (4.330m * idade);

                if (Masculino.Checked)
                {
                    Reusutado.Text = $"Seu TMB é: {tmbMasculino:F2} kcal/dia";


                }
                else if (Feminino.Checked)
                {
                    Reusutado.Text = $"Seu TMB é: {tmbFeminino:F2} kcal/dia";
                }
                else
                {
                    MessageBox.Show("Por favor, selecione o gênero.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos para peso, altura e idade.");
            }


        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            Reusutado.Text = "";
            Peso.Text = "";
            Altura.Text = "";
            Idade.Text = "";
        }
    }
}
