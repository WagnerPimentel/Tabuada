using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            int contador = 1;

            string tabuada = "";

            while (contador <= 10)
            {
                int resultado = numero * contador;
                tabuada += ($"{numero} x {contador} = {resultado}\n");

                contador++;
            }
            txtTabuada.Text = tabuada;
        }
    }
}
