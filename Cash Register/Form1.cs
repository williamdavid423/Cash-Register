using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        double burgerPrice = 7.50;
        double slidersPrice = 3.50;
        double juicePrice = 3.25;
        int burgerAmount = 0;
        int sliderAmount = 0;
        int juiceAmount = 0;
        double total = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double totalAmount = 0;
        double changeAmount = 0;
        double amountTendered = 0;

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
            try
            {
                burgerAmount = Convert.ToInt32(textBox1.Text);
                juiceAmount = Convert.ToInt32(textBox5.Text);
                sliderAmount = Convert.ToInt32(textBox4.Text);

                total = burgerPrice * burgerAmount + slidersPrice * sliderAmount + juicePrice * juiceAmount;
                subLabel.Text = $"{total.ToString(".00")}";
                taxAmount = total * taxRate;
                taxAmountLabel.Text = $"{taxAmount.ToString(".00")}";
                totalAmount = total + taxAmount;
                totalAmountLabel.Text = $"{totalAmount.ToString(".00")}";
            }
            catch
            {

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            amountTendered = Convert.ToDouble(tenderedTextbox.Text);
            changeAmount = amountTendered - totalAmount;
            changeAmountLabel.Text = $"{changeAmount.ToString(".00")}";
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            burgerAmount = Convert.ToInt32(textBox1.Text);
            juiceAmount = Convert.ToInt32(textBox5.Text);
            sliderAmount = Convert.ToInt32(textBox4.Text);

            receiptTitleLabel.Text = "Bill's Burger's Inc.";
            Refresh();
            Thread.Sleep(1000);

            itemsLabel.Text = "Hamburgers";
            itemPriceLabel.Text = $"x{burgerAmount} @ ${burgerPrice.ToString(".00")}";
            Refresh();
            Thread.Sleep(500);
            itemsLabel.Text += "\nSliders";
            itemPriceLabel.Text += $"\nx{sliderAmount} @ ${slidersPrice.ToString(".00")}";
            Refresh();
            Thread.Sleep(500);
            itemsLabel.Text += "\nBurger Juice";
            itemPriceLabel.Text += $"\nx{juiceAmount} @ ${juicePrice.ToString(".00")}";
            Refresh();
            Thread.Sleep(1000);

            receiptTaxLabel.Text = "Subtotal";
            receiptTaxAmount.Text = $"${total.ToString(".00")}";
            Refresh();
            Thread.Sleep(500);
            receiptTaxLabel.Text += "\nTax";
            receiptTaxAmount.Text += $"\n${taxAmount.ToString(".00")}";
            Refresh();
            Thread.Sleep(500);
            receiptTaxLabel.Text += "\nTotal";
            receiptTaxAmount.Text += $"\n${totalAmount.ToString(".00")}";
            Refresh();
            Thread.Sleep(1000);

            tenderedLabel.Text = "Tendered";
            tenderedAmount.Text = $"{amountTendered.ToString(".00")}";
            Refresh();
            Thread.Sleep(500);
            tenderedLabel.Text += "\nChange";
            tenderedAmount.Text += $"\n{changeAmount.ToString(".00")}";
            Refresh();
            Thread.Sleep(1000);

            niceDayLabel.Text = "Have a Nice Day!";

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
