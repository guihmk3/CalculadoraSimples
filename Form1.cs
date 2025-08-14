using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // validação dos campo:
            if (txbNum1.Text == "")
            {
                MessageBox.Show("Preencha o número 1:", "Erro!,",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbNum2.Text == "")
            {
                MessageBox.Show("Preencha o número 21", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbOperacao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Operação!", "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                double n1 = double.Parse(txbNum1.Text);
                double n2 = double.Parse(txbNum2.Text);
                double resultado = 0;

                if (cmbOperacao.Text == "Adição")
                {
                    resultado = n1 + n2;
                }
                else if (cmbOperacao.Text == "Subtração")
                {
                    resultado = n1 - n2;
                }

                else if (cmbOperacao.Text == "Multiplicação")
                {
                    resultado = n1 * n2;
                }

                else if (cmbOperacao.Text == "Divisão")
                {
                    if(n2 != 0)
                    {
                        resultado = n1 / n2;
                    }
                    else
                    {
                        MessageBox.Show("Impossivel Dividir por Zero!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Opção inválida!");
                }
                lblResultado.Text = resultado.ToString();

            }
        } } 
}
