using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej20._CalcularSumaSerieN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operacion x = new Operacion();
            double counter = double.Parse(textBox1.Text);
            double sum = 1 + x.AddSum(counter);
            this.textBox2.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult salir;
            salir = MessageBox.Show("Deseas salir de la aplicacion?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
