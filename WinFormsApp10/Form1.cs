using Microsoft.VisualBasic.Devices;
using System;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double wag = 0;
        double salry = 0;
        double hourofweek = 0;
        double Rate = 0;
        double Tax = 0;
        double totalwage;


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Wage_Click(object sender, EventArgs e)
        {
            Wage();
        }
        private void Salary_Click(object sender, EventArgs e)
        {
            slry();
        }
        private double Tax2()
        {
            Tax = int.Parse(Tax1.Text);
            Tax = Tax / 100;
            return Tax;
        }
        private void Wage()
        {
            double hweek;

            double wgeovr;

            double hrate;

            hourofweek = int.Parse(number_hours.Text);

            Rate = int.Parse(number_rate.Text);

            hrate = Rate * 2;



            if (hourofweek <= 40)
            {
                wag = hourofweek * Rate;

                totalwage = wag;

                totalwage = totalwage - (totalwage * Tax2());
            }
            else
            {
                hweek = hourofweek - 40;

                wgeovr = hweek * hrate;

                totalwage = wgeovr + wag;
                totalwage = totalwage - (totalwage * Tax2());
            }

            wge.Text = totalwage + "$";

        }
        private void slry()
        {
            salry = totalwage * 4;

            slary.Text = salry + "$";
        }

        private void rate_Click(object sender, EventArgs e)
        {

        }

        private void number_rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tax_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number_hours.Text = number_rate.Text = Tax1.Text = null;
        }
    }
}