using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praca_domowa_2_Zadanie_dodatkowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double ObliczObjetosc()
        {
            double a = Convert.ToDouble(dlugosc.Text);
            double b = Convert.ToDouble(szerokosc.Text);
            double h_basenu = Convert.ToDouble(glebokosc.Text);
            double h_brodzika = Convert.ToDouble(wysokosc.Text);
            double r = Convert.ToDouble(podstawa.Text);
            double mur = Convert.ToDouble(murek.Text);
            return a * b * h_basenu - (h_brodzika * Math.PI * (2 * r * mur + mur * mur)) - (Math.PI * Math.Pow((r + mur), 2) * (h_basenu - h_brodzika));

        }

        private double ObliczSol()
        {
            return ObliczObjetosc() * 0.035*997;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Objetosc wody w basenie wynosi: " + Convert.ToString(ObliczObjetosc()) + " m3\nNatomiast masa soli: " + Convert.ToString(ObliczSol()) + "kg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
