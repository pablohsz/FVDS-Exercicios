using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExercicio
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProdutos.SelectedIndex)
            {
                case 1:
                    lbValordoProduto.Text = "500,00";
                    break;

                case 2:
                    lbValordoProduto.Text = "2.200,00";
                    break;

                case 3:
                    lbValordoProduto.Text = "4.000,00";
                    break;

                case 4:
                    lbValordoProduto.Text = "800,00";
                    break;

                case 5:
                    lbValordoProduto.Text = "1.000,00";
                    break;

            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cmbProdutos.Text = "[ SELECIONE ]";
            cmbLocal.Text = "[ SELECIONE ]";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbProdutos.Text = "[ SELECIONE ]";
            cmbLocal.Text = "[ SELECIONE ]";
            lbFrete.Text = "0";
            lbValordoProduto.Text = "0";
            lbTotal.Text = "0";
        }

        private void cmbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLocal.SelectedIndex)
            {
                case 1:
                    lbFrete.Text = "50,00";
                    break;

                case 2:
                    lbFrete.Text = "20,00";
                    break;

                case 3:
                    lbFrete.Text= "40,00";
                    break;

                case 4:
                    lbFrete.Text= "80,00";
                    break;

                case 5:
                    lbFrete.Text = "10,00";
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (cmbProdutos.SelectedIndex.Equals(0))
            {
                result = MessageBox.Show("Selecione um produto para continuar.", "Selecione um produto", MessageBoxButtons.OK);
            } 
            else if (cmbLocal.SelectedIndex.Equals(0))
            {
                result = MessageBox.Show("Selecione um o local de entrega para continuar.", "Selecione um local", MessageBoxButtons.OK);
            } else
            {
                double total;
                total = Convert.ToDouble(lbValordoProduto.Text) + Convert.ToDouble(lbFrete.Text);
                lbTotal.Text = String.Format("{0:C}", total);
            }
        }
    }
}
