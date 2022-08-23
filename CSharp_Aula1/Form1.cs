using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConcatenacao_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;

            txtNomeCompleto.Text = nome + " "+ sobrenome; 
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            int rst = n1 + n2;

            if (rst > 10)
            {
                txtResultado.Text = "O valor é : " + rst.ToString() + " que é maior que 10.";
            }
            else
            {
                if (rst < 10)
                {
                    txtResultado.Text = "O valor é : " + rst.ToString() + " que é menor que 10.";
                }
                else
                {
                    txtResultado.Text = "O valor é : " + rst.ToString() + " igual a 10.";
                }
            }
                
            

        }
    }
}
