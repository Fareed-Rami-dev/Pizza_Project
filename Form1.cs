using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project_Course_14
{
    public partial class Form1 : Form
    {
        decimal totalPrice = 0.0m;
        public Form1()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_smallSize.Checked)
            {
                lbl_size.Text = rd_smallSize.Text;
            }
            calculateTotalPrice();
        }
        
     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_TotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_mediumSize.Checked)
            {
                lbl_size.Text = rd_mediumSize.Text;
            }
            calculateTotalPrice();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_largeSize.Checked)
            {
                lbl_size.Text = rd_largeSize.Text;
            }
            calculateTotalPrice();
        }

   

        private void rd_eatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_eatIn.Checked)
            {
                lbl_WhereToEat.Text = rd_eatIn.Text;
            }
            calculateTotalPrice();
        }

        private void rd_TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_TakeOut.Checked)
            {
                lbl_WhereToEat.Text = rd_TakeOut.Text;
            }
            calculateTotalPrice();
        }

        private void rd_smallCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_smallCrust.Checked)
            {
                lbl_crustType.Text = rd_smallCrust.Text;
            }
            calculateTotalPrice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void calculateTotalPrice()
        {
            this.totalPrice = 0;
            if (rd_smallSize.Checked)
            {
                totalPrice += 5.50m;
            }
            else if (rd_mediumSize.Checked)
            {
                totalPrice += 8.50m;
            }
            else if (rd_largeSize.Checked)
            {
                totalPrice += 10.50m;
            }
            if (chk_extraCheese.Checked)
            {
                totalPrice += 1.50m;
            }
            if (chk_mushrooms.Checked)
            {
                totalPrice += 1.00m;
            }
            if (chk_tomatoes.Checked)
            {
                totalPrice += 1.00m;
            }
            if (chk_onion.Checked)
            {
                totalPrice += 0.75m;
            }
            if (chk_olives.Checked)
            {
                totalPrice += 0.90m;
            }
            if (chk_greenPepper.Checked)
            {
                totalPrice += 0.75m;
            }
            lbl_TotalPrice.Text = (totalPrice.ToString()+" $");
        }
        private void writeToppings()
        {
            string str="";
            if (chk_extraCheese.Checked)
            {
                str += chk_extraCheese.Text+" ";
            }
            if (chk_mushrooms.Checked)
            {
                str += chk_mushrooms.Text+" ";
            }
            if (chk_tomatoes.Checked)
            {
                str += chk_tomatoes.Text + " ";
            }
            if (chk_onion.Checked)
            {
                str += chk_onion.Text + " ";
            }
            if (chk_olives.Checked)
            {
                str += chk_olives.Text + " ";
            }
            if (chk_greenPepper.Checked)
            {
                str += chk_greenPepper.Text + " ";
            }
            lbl_toppings.Text = str;
        }
        private void chk_extraCheese_CheckedChanged(object sender, EventArgs e)
        {
            writeToppings();
            calculateTotalPrice();
        }

        private void chk_mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            writeToppings();
            calculateTotalPrice();
        }

        private void chk_tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            writeToppings();
            calculateTotalPrice();
        }

        private void chk_olives_CheckedChanged(object sender, EventArgs e)
        {
            writeToppings();
            calculateTotalPrice();
        }

        private void chk_greenPepper_CheckedChanged(object sender, EventArgs e)
        {
            writeToppings();
            calculateTotalPrice();
        }

        private void chk_onion_CheckedChanged(object sender, EventArgs e)
        {
            writeToppings();
            calculateTotalPrice();
        }

        private void rd_thinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_thinCrust.Checked)
            {
                lbl_crustType.Text= rd_thinCrust.Text;
            }
            calculateTotalPrice();
        }

        private void btn_resetForm_Click(object sender, EventArgs e)
        {
            chk_extraCheese.Checked = false;
            chk_greenPepper.Checked = false;
            chk_onion.Checked = false;
            chk_mushrooms.Checked = false;
            chk_olives.Checked = false;
            chk_tomatoes.Checked = false;
            totalPrice = 0;
            rd_smallSize.Checked = true;
            rd_thinCrust.Checked = true;
            rd_eatIn.Checked = true;
            calculateTotalPrice();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btn_orderPizza_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to confirm your order? Yes/No", 
                "Confirm Order", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.OK)
            {

            }
        }
    }

}