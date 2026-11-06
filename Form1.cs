using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_windowsforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sortColor();

            ProgressBar.Value += 1;

            if (ProgressBar.Value >= ProgressBar.Maximum)
            {
                ProgressBar.Value = 0;
            }


        }

        private void sortColor()
        {
            Color[] colors = { Color.Red, Color.Blue, Color.Chocolate, Color.DarkMagenta, Color.DeepPink, Color.Ivory, Color.MediumPurple };

            Random sorteio = new Random();

            int indice = sorteio.Next(colors.Length);

            this.BackColor = colors[indice];
        }

       
        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;
            ProgressBar.Value = 0;
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro realizado com sucesso!");
        }
    }
}
