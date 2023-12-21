using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorCaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValorSaque.Text) && int.TryParse(txtValorSaque.Text, out int valorSaque))
            {
                int notas100 = 0, notas50 = 0, notas20 = 0, notas10 = 0;

                while (valorSaque >= 100)
                {
                    valorSaque -= 100;
                    notas100++;
                }

                while (valorSaque >= 50)
                {
                    valorSaque -= 50;
                    notas50++;
                }

                while (valorSaque >= 20)
                {
                    valorSaque -= 20;
                    notas20++;
                }

                while (valorSaque >= 10)
                {
                    valorSaque -= 10;
                    notas10++;
                }

                MessageBox.Show($"Notas de R$100: {notas100}\nNotas de R$50: {notas50}\nNotas de R$20: {notas20}\nNotas de R$10: {notas10}", "Notas entregues");
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido para saque.", "Erro");
            }
        }
    }
}
