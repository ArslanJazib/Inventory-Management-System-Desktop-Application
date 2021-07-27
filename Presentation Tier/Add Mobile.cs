using System;
using System.Drawing;
using System.Windows.Forms;

namespace VPLabMidTask2
{
    public partial class Add_Mobile : Form
    {
        // Will store the reference of the MobileShop form
        mobileShop shop_ref;

        public Add_Mobile()
        {
            InitializeComponent();
        }
        //Parameterized contructor
        public Add_Mobile(mobileShop shop)
        {
            InitializeComponent();
            //Storing the reference
            this.shop_ref = shop;
            // Creating events deal with place holder in the textboxes
            name_tbox.GotFocus += OnNameFocus;
            name_tbox.LostFocus += OnNameDefocus;
            number_tbox.GotFocus += OnNumFocus;
            number_tbox.LostFocus += OnNumDefocus;
            price_tbox.GotFocus += OnPriceFocus;
            price_tbox.LostFocus += OnPriceDefocus;
            stock_tbox.GotFocus += OnStockFocus;
            stock_tbox.LostFocus += OnStockDefocus;
        }
        private void Add_Mobile_Load(object sender, EventArgs e)
        {

        }
        private void OnStockDefocus(object sender, EventArgs e)
        {
            if (stock_tbox.Text.Length == 0)//Placing Placeholder
            {
                stock_tbox.ForeColor = Color.DarkGray;
                stock_tbox.Text = "Enter Stock";
            }
        }

        private void OnStockFocus(object sender, EventArgs e)
        {
            if (stock_tbox.Text == "Enter Stock" && stock_tbox.Text != "")//If the textbox does'nt have any value from the user
            {
                stock_tbox.Text = "";//removing the Placeholder
                stock_tbox.ForeColor = Color.Black;
            }
        }

        private void OnPriceDefocus(object sender, EventArgs e)
        {
            if (price_tbox.Text.Length == 0)//Placing Placeholder
            {
                price_tbox.ForeColor = Color.DarkGray;
                price_tbox.Text = "Enter Price";
            }
        }

        private void OnPriceFocus(object sender, EventArgs e)
        {
            if (price_tbox.Text == "Enter Price" && price_tbox.Text != "")//If the textbox does'nt have any value from the user
            {
                price_tbox.Text = "";//removing the Placeholder
                price_tbox.ForeColor = Color.Black;
            }
        }

        private void OnNumDefocus(object sender, EventArgs e)
        {
            if (number_tbox.Text.Length == 0)//Placing Placeholder
            {
                number_tbox.ForeColor = Color.DarkGray;
                number_tbox.Text = "Enter Model Number";
            }
        }

        private void OnNumFocus(object sender, EventArgs e)
        {
            if (number_tbox.Text == "Enter Model Number" && number_tbox.Text != "")//If the textbox does'nt have any value from the user
            {
                number_tbox.Text = "";//removing the Placeholder
                number_tbox.ForeColor = Color.Black;
            }
        }

        private void OnNameDefocus(object sender, EventArgs e)
        {
            if (name_tbox.Text.Length == 0)//Placing Placeholder
            {
                name_tbox.ForeColor = Color.DarkGray;
                name_tbox.Text = "Enter Company Name";
            }
        }

        private void OnNameFocus(object sender, EventArgs e)
        {
            if (name_tbox.Text == "Enter Company Name" && name_tbox.Text != "")//If the textbox does'nt have any value from the user
            {
                name_tbox.Text = "";//removing the Placeholder
                name_tbox.ForeColor = Color.Black;
            }
        }

        private void mobileDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shop_ref.Show();
            this.Hide();
        }

        private void Add_Mobile_FormClosing(object sender, FormClosingEventArgs e)
        {
            shop_ref.Show();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //IF all the textboxes are filled with input
            if (name_tbox.Text != "Enter Company Name" && number_tbox.Text != "Enter Model Number" && price_tbox.Text != "Enter Price" && stock_tbox.Text != "Enter Stock")
            {
                //Comparing all the inputs with regular expressions
                byte status = shop_ref.dataHandler.InputValidation(name_tbox.Text, number_tbox.Text, price_tbox.Text,stock_tbox.Text);
                //If all the inputs are correct
                if (status == 1)
                {
                    //Insert the inputs in the data grid
                    shop_ref.mobileData.Rows.Add(name_tbox.Text, number_tbox.Text, price_tbox.Text, stock_tbox.Text);
                    MessageBox.Show("Mobile added ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //If name is incorrect
                else if (status == 2)
                {
                    MessageBox.Show("Incorrect name format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //If model is incorrect
                else if (status == 3)
                {
                    MessageBox.Show("Incorrect model format ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //If price is incorrect
                else if (status == 4)
                {
                    MessageBox.Show("Incorrect price format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //If stock is incorrect
                else if (status == 5)
                {
                    MessageBox.Show("Incorrect stock format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //If all inputs are incorrect
                else if (status == 6)
                {
                    MessageBox.Show("Incorrect name format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Incorrect model format ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Incorrect price format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Incorrect stock format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all textboxes", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
