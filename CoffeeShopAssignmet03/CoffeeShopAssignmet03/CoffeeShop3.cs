using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopAssignmet03
{
    public partial class CoffeeShop3 : Form
    {
        const int size = 10;
        int index = 0;
       string[] customerName = new string[size];
        string[] contactNumber = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];

        int[] quantity = new int[size];


        public CoffeeShop3()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (orderComboBox.Text == "")
            {
                MessageBox.Show("please select an item");
            }
            else
            {
                MessageBox.Show("successful  item  addede here");
            }

            int totalPrice = 0;
            
            if (size > index)
            {
                customerName[index] = customerNameTextBox.Text;
                contactNumber[index] = contactNoTextBox.Text;
                address[index] = addressTextBox.Text;
                order[index] = orderComboBox.Text;
                quantity[index] = Convert.ToInt32(quantityTextBox.Text);
                 
            }

            if (order[index] == "Black")
            {
                totalPrice = quantity[index] * 120;
            }
            else if (order[index] == "Cold")
            {
                totalPrice = quantity[index] * 100;
            }
            else if (order[index] == "Hot")
            {
                totalPrice = quantity[index] * 90;
            }
            else if (order[index] == "Regular")
            {
                totalPrice = quantity[index] * 80;
            }
             
            showRichTextBox.AppendText("\n\nName: " + customerName[index]
                + "\nContact: " + contactNumber[index] + "\nAddress: " + address[index]
                + "\nOrder: " + order[index] + "\nQuantity: " + quantity[index]
                + "\nTotal Price " + totalPrice);
            customerNameTextBox.Text = " ";
            contactNoTextBox.Text = " ";
            addressTextBox.Text = " ";
            orderComboBox.Text = "Select An Item";
            quantityTextBox.Text = " ";




        }
    }
}
