using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenadorDeLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenaLista_Click(object sender, EventArgs e)
        {
            // Obter os números da caixa de texto e separá-los
            string[] numerosString = txtNumeros.Text.Split(',');
            int[] numeros = Array.ConvertAll(numerosString, int.Parse);

            // Chamar o algoritmo de ordenação 
           Ordenarlista(numeros);

            // Exibir a lista ordenada na caixa de texto de saída
            txtResultado.Text = string.Join(", ", numeros);
        }
    }
    // Algoritmo para ordenar a lista
    private void Ordenarlista(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Trocar os elementos se estiverem na ordem errada
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
