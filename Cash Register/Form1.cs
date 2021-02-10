using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double burgerPrice = 7.50;
        double slidersPrice = 3.50;
        double juicePrice = 3.25;
        int burgerAmount;
        int sliderAmount;
        int juiceAmount;
        double total;
        double taxAmount = 0.13;
        double totalAmount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void JuiceLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalsButton_Click(object sender, EventArgs e)
        {
            total = burgerPrice * burgerAmount + slidersPrice * sliderAmount + juicePrice * juiceAmount;
            burgerAmount = TextBox1
            subTotalLabel.Text += $"{total}";


        }
    }
}
