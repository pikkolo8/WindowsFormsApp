using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{

    public partial class Form1 : Form
    {
        double Number1, Number2, Result;

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textNumber1.Text);
            Number2 = Convert.ToDouble(textNumber2.Text);
            Result = Number1 - Number2;
            txtResult.Text = Result.ToString();
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(textNumber2.Text) !=0)
            {
                Number1 = Convert.ToDouble(textNumber1.Text);
                Number2 = Convert.ToDouble(textNumber2.Text);
                Result = Number1 / Number2;
                txtResult.Text = Result.ToString();
            }
            else
            {

            }
            
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textNumber1.Text);
            Number2 = Convert.ToDouble(textNumber2.Text);
            Result = Number1 * Number2;
            txtResult.Text = Result.ToString();
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textNumber1.Text);
            Number2 = Convert.ToDouble(textNumber2.Text);
            Result = Number1 + Number2;
            txtResult.Text = Result.ToString();
        }

        private void textNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textNumber2.Text.Contains('.') == true : true))
            {
                e.Handled = true;
            }
        }

        private void textNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textNumber1.Text.Contains('.') == true : true))
            {
                e.Handled = true;
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
