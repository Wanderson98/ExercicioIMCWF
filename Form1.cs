using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Aula72
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            IMC imc = new IMC();
            imc.Altura = double.Parse(txtAltura.Text);
            imc.Peso = double.Parse(txtPeso.Text);

            MaterialMessageBox.Show($"Seu IMC é: {imc.CalcularIMC():F2} você está na faixa {imc.VerificarStatus()}" , false);
        }
    }
}
