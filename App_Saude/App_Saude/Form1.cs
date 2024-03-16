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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criar uma instância do segundo formulário
            Form2 segundoFormulario = new Form2();

            // Exibir o segundo formulário
            segundoFormulario.Show();


            // Opcional: ocultar o formulário atual se desejado
            this.Hide();
        }

        
    }

   

}
