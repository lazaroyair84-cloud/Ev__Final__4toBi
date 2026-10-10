using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev__Final__4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            byte Num1 = byte.Parse(TextVar1.Text);
            byte Num2 = byte.Parse(TextVar2.Text);
            int Producto = Num1 * Num2;
            MessageBox.Show("la respuesta es://" + Producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(TextVar1.Text);
            Byte Num2 = Byte.Parse(TextVar2.Text);
            int suma = Num1 + Num2;
            MessageBox.Show("La R// es " + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextVar1.Text);
            int Num2 = int.Parse(TextVar2.Text);
            int Potencia = 1;
            int J = 0;
            while (J != Num2)
            {
                Potencia = Potencia * Num1;
                J++;
            }
            MessageBox.Show("El resultado es: " + Potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextVar1.Text);
            float Num2 = float.Parse(TextVar2.Text);

            if (Num2 > 0)
            {
                float division = Num1 / Num2;
                MessageBox.Show("la R// es" + division);
            }
            else
            {
                MessageBox.Show("la division es indefinida");
            }
        }
    }
}
