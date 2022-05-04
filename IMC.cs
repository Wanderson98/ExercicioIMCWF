using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Aula72
{
    internal class IMC
    {
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double CalcularIMC()
        {
            return Peso / (Altura *Altura);
        }

        public string VerificarStatus()
        {
            double imc = CalcularIMC();
            if (imc <= 18.5)
            {
                return "Abaixo do Peso";
            } else if (imc < 25)
            {
                return "Peso Normal";
            } else if (imc < 30)
            {
                return "Sobrepeso";
            }
            else if (imc < 35)
            {
                return "Obesidade I";
            }
            else if (imc < 40)
            {
                return "Obesidade II";
            }
            else
            {
                return "Obesidade Morbida";
            }
        }
    }
}
