using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesoideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
        }

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = 0, pesoideal = 0;
                altura = double.Parse(txtAltura.Text);
                if (cmbSexo.Text == "Feminino")
                {
                    pesoideal = (62.7 * altura) - 44.7;
                    MessageBox.Show(txtNome.Text + " Seu peso ideal é: " + pesoideal.ToString(), "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Maculino")
                {
                    pesoideal = (72.7 * altura) - 58;
                    MessageBox.Show(txtNome.Text + " Seu peso ideal é: " + pesoideal.ToString(), "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Acho que você não sabe seu sexo!", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os valores informados.", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
