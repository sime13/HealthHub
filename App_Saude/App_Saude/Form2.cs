using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Saude
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            decimal altura = decimal.Parse(Altura.Text);
            decimal peso = decimal.Parse(Peso.Text);
            decimal imc = peso/(altura*altura);
            if (imc < 18.5m)
            {
                Resultado.Text = $"Seu IMC é: {imc:F2}. Você está abaixo do peso.";
            }
            else if (imc >= 18.5m && imc <= 24.9m)
            {
                Resultado.Text = $"Seu IMC é: {imc:F2}. Você está no peso normal.";
            }
            else
            {
                Resultado.Text = $"Seu IMC é: {imc:F2}. Você está obeso.";
            }



        }
    }
}
