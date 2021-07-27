using System;
using System.Drawing;
using System.Windows.Forms;
using LogicTier;
namespace VPLabMidTask2
{
    public partial class Input : Form
    {
        // Will store the reference of the MobileShop form
        mobileShop shop_ref;
        public Input()
        {
            InitializeComponent();
        }
        //Parameterized contructor
        public Input(mobileShop shop)
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
            // All textboxes are disabled by default
            name_tbox.Enabled = false;
            number_tbox.Enabled = false;
            price_tbox.Enabled = false;
            stock_tbox.Enabled = false;
        }
        private void Input_Load(object sender, EventArgs e)
        {
            //If user selected the company name option in MobileShop form set enable name textbox
            if (shop_ref.cName.Checked == true)
            {
                name_tbox.Enabled = true;
            }
            //If user selected the model number option in MobileShop form set enable number textbox
            else if (shop_ref.mNumber.Checked == true)
            {
                number_tbox.Enabled = true;
            }
            //If user selected the price option in MobileShop form set enable price textbox
            else if (shop_ref.priceTag.Checked==true)
            {
                price_tbox.Enabled = true;
            }
            //If user selected the stock option in MobileShop form set enable stock textbox
            else if (shop_ref.sellStock.Checked == true)
            {
                stock_tbox.Enabled = true;
            }
        }
        
        private void OnStockDefocus(object sender, EventArgs e)
        {
            if (stock_tbox.Text.Length == 0)//Placing the Placeholder
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
            if (price_tbox.Text.Length == 0)//Placing the Placeholder
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
            if (number_tbox.Text.Length == 0)//Placing the Placeholder
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
            if (name_tbox.Text.Length == 0)//Placing the Placeholder
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
            //Opening MobileShop form
            shop_ref.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // To use input validation function
            DataHandler dataHandler = new DataHandler();
            //Regular Expression is compared with company name
            if (shop_ref.cName.Checked == true)
            {
                if (dataHandler.InputValidation(name_tbox.Text, 1) == 1)
                {
                    //Update value at the update_index
                    shop_ref.mobileData.Rows[shop_ref.update_index].Cells[0].Value = name_tbox.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            //Regular Expression is compared with model number
            if (shop_ref.mNumber.Checked == true)
            {
                if (dataHandler.InputValidation(number_tbox.Text, 2) == 1)
                {
                    //Update value at the update_index
                    shop_ref.mobileData.Rows[shop_ref.update_index].Cells[1].Value = number_tbox.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Regular Expression is compared with price
            if (shop_ref.priceTag.Checked == true)
            {
                if (dataHandler.InputValidation(price_tbox.Text, 3) == 1)
                {
                    //Update value at the update_index
                    shop_ref.mobileData.Rows[shop_ref.update_index].Cells[2].Value = price_tbox.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Regular Expression is compared with stock
            if (shop_ref.sellStock.Checked == true)
            {
                if (dataHandler.InputValidation(stock_tbox.Text, 4) == 1)
                {
                    //Update value at the update_index
                    shop_ref.mobileData.Rows[shop_ref.update_index].Cells[3].Value = stock_tbox.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect format", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Input_FormClosing(object sender, FormClosingEventArgs e)
        {
            shop_ref.Show();
        }
    }
}
