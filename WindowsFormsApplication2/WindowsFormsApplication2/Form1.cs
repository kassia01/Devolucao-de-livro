using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
     
            TimeSpan data =Convert.ToDateTime(lblData.Text) - Convert.ToDateTime(txtDevolucao.Text);
            int totalDias = data.Days;
            txtDiasAtraso.Text = totalDias.ToString();
            RadioButton rb = radioButton2;

            if (rb.Checked)
            {
                double diaAtraso, total;
                diaAtraso = Convert.ToDouble(txtDiasAtraso.Text);
                total = diaAtraso * 1.40;
                txtValorPagar.Text = total.ToString("C");

            }
            else

                MessageBox.Show("Livro devolvido dentro do prazo estabelecido,Parabens!");


        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblData.Text = Convert.ToString(DateTime.Now);
        }

       
    }
}
