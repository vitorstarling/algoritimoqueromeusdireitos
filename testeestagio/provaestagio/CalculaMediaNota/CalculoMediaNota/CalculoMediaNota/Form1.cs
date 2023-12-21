using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMediaNota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Obtendo as notas e pesos das provas
                double nota1 = Convert.ToDouble(txtNota1.Text);
                double nota2 = Convert.ToDouble(txtNota2.Text);
                double nota3 = Convert.ToDouble(txtNota3.Text);

                double peso1 = Convert.ToDouble(txtPeso1.Text);
                double peso2 = Convert.ToDouble(txtPeso2.Text);
                double peso3 = Convert.ToDouble(txtPeso3.Text);

                // Calculando a média ponderada
                double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);

                // Exibindo a média na caixa de texto de resultado
                txtResultado.Text = media.ToString("0.00");
            }
        }
    }
}

