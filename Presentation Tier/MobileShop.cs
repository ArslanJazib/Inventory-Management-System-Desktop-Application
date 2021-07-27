using System;
using System.Windows.Forms;
using LogicTier;
namespace VPLabMidTask2
{
    public partial class mobileShop : Form
    {
        /* Datahandler object will be used to access the Logic Tier
         contructor also reads the content of the file into a list*/
        public DataHandler dataHandler = new DataHandler();
        bool delete_flag = false;//To check if the user wants to delete value
        bool update_flag = false;//To check if the user wants to update value
        public int update_index;//To store the selected row index of the value which is to be updated
        public mobileShop()
        {
            InitializeComponent();
        }

        private void mobileShop_Load(object sender, EventArgs e)
        {
            //Loading the data according to phone list size into the data grid
            for (int index = 0; index < DataHandler.total; index++)
            {
                //Will be passed as reference
                string companyName = null;
                string modelNumber = null;
                string price = null;
                string stock = null;
                //Loads the value into the refernce variables
                dataHandler.LoadDataGird(ref companyName, ref modelNumber, ref price, ref stock);
                //To access the next element in the list
                DataHandler.counter++;
                //Inserting the data in the grid
                mobileData.Rows.Add(companyName, modelNumber, price, stock);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            //If user filled the textbox
            if (input_tbox.Text.Length > 0)
            {
                //Hiding all the irrelevant rows
                foreach (DataGridViewRow row in mobileData.Rows)
                {
                    //Ignoring the last empty roe
                    if (!row.IsNewRow)
                    {
                        row.Visible = false;
                    }
                }
                // If user wants to search through company name
                if (cName.Checked == true)
                {
                    //Passing the column index and the operation no e.g search =1
                    SearchUpdateDelete(0,1);
                }
                //If user wants to search through model number
                if (mNumber.Checked == true)
                {
                    //Model number is considered to be unique
                    //Looping through all rows
                    foreach (DataGridViewRow row in mobileData.Rows)
                    {
                        try
                        {
                            //If the value in input box matches the values in 2nd colum make it visible
                            if (row.Cells[1].Value.ToString().Equals(input_tbox.Text))
                            {
                                row.Visible = true;
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                // If user wants to search through price
                if (priceTag.Checked == true)
                {
                    //Passing the column index and the operation no e.g search =1
                    SearchUpdateDelete(2, 1);
                }
                // If user wants to search through stock
                if (sellStock.Checked == true)
                {
                    //Passing the column index and the operation no e.g search =1
                    SearchUpdateDelete(3, 1);
                }
            }
            else
            {
                MessageBox.Show("Textbox is empty please input", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            //If user filled the textbox
            if (input_tbox.Text.Length > 0)
            {
                //Hiding all the irrelevant rows
                foreach (DataGridViewRow row in mobileData.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = false;
                    }
                }
                //If the user wants to up date name
                if (cName.Checked == true)
                {
                    //Passing the column index and the operation no e.g update =2
                    SearchUpdateDelete(0, 2);
                }
                //If user wants to update model number
                if (mNumber.Checked == true)
                {
                    //Model number is considered to be unique
                    //Looping through all rows
                    foreach (DataGridViewRow row in mobileData.Rows)
                    {
                        try
                        {
                            //If the value in input box matches the values in 2nd colum make it visible
                            if (row.Cells[1].Value.ToString().Equals(input_tbox.Text))
                            {
                                row.Visible = true;
                                update_index = row.Index;//Set the update index equal to the row index which is to be used by Input form
                                //Opening input form
                                Input update = new Input(this);
                                update.Show();
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                //If the user wants to update price
                if (priceTag.Checked == true)
                {
                    //Passing the column index and the operation no e.g update =2
                    SearchUpdateDelete(2, 2);
                }
                //If the user wanys to update stock
                if (sellStock.Checked == true)
                {
                    //Passing the column index and the operation no e.g update =2
                    SearchUpdateDelete(3, 2);
                }
            }
            else
            {
                MessageBox.Show("Textbox is empty please input", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            //If the textbox is filled
            if (input_tbox.Text.Length > 0)
            {
                // Ignoring the irrelevant rows
                foreach (DataGridViewRow row in mobileData.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = false;
                    }
                }
                //If the user wans to delete name
                if (cName.Checked == true)
                {
                    //Passing the column index and the operation no e.g delete =3
                    SearchUpdateDelete(0, 3);
                }
                //If the user wants to delete model
                if (mNumber.Checked == true)
                {
                    //Model number is considered to be unique
                    //Looping through all rows
                    foreach (DataGridViewRow row in mobileData.Rows)
                    {
                        try
                        {
                            //If the value in input box matches the values in 2nd colum make it visible
                            if (row.Cells[1].Value.ToString().Equals(input_tbox.Text))
                            {
                                row.Visible = true;
                                delete_flag = true;//Delete flag will be used by the double click event to delete a row
                                MessageBox.Show("Double click on the cell of the record you want to delete", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                //If the user wants to delete price
                if (priceTag.Checked == true)
                {
                    //Passing the column index and the operation no e.g delete =3
                    SearchUpdateDelete(2, 3);
                }
                //If the user wants tp delete stock
                if(sellStock.Checked==true)
                {
                    //Passing the column index and the operation no e.g delete =3
                    SearchUpdateDelete(3, 3);
                }
            }
            else
            {
                MessageBox.Show("Textbox is empty please input", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // This function makes the rows matching the entered value visible sets the delete and update flag as true for them
        void SearchUpdateDelete(int col_index,int choice)
        {
             delete_flag = false;
             update_flag = false;
            foreach (DataGridViewRow row in mobileData.Rows)
            {
                if (!row.IsNewRow)
                {
                    try
                    {
                        // Entered value if found in the chosen column row visibity is set true
                        if (row.Cells[col_index].Value.ToString().Equals(input_tbox.Text))
                        {
                            row.Visible = true;
                            //If there is another value matching the same input with the same column
                            for (int loop = row.Index + 1; loop < mobileData.RowCount - 1; loop++)
                            {
                                if (mobileData.Rows[loop].Cells[col_index].Value.ToString().Equals(input_tbox.Text))
                                {
                                    mobileData.Rows[loop].Visible = true;
                                }

                            }
                            //If user presses update button
                            if (choice == 2)
                            {
                                update_flag = true;
                                MessageBox.Show("Double click on any cell of the record you want to update", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                            //If user presses delete button
                            if (choice == 3)
                            {
                                delete_flag = true;
                                MessageBox.Show("Double click on any cell of the record you want to delete", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                
            }
        }

        private void mobileShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Looping through all the rows
            foreach (DataGridViewRow row in mobileData.Rows)
            {
                // Ignoring the last empty row
                if (!row.IsNewRow)
                {
                    try
                    {
                        //Storing each column with in the row in a text file
                        dataHandler.StoreDataGird
                        (row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString());
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void mobileData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // If delete flag is set to true delete the clicked row
            if (delete_flag == true)
            {
                mobileData.Rows.RemoveAt(e.RowIndex);
                delete_flag = false;
            }
            //If the update flag is set to true set the update index as the clicked row index
            if (update_flag == true)
            {
                update_index = e.RowIndex;
                //Open the input form also passing reference of this form
                Input input = new Input(this);
                input.Show();
                this.Hide();

            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add_Mobile addmobile = new Add_Mobile(this);
            addmobile.Show();
            this.Hide();
        }
        // Unless chooses any options from the options groupbox keep the input textbox disables
        //If user clicks on any radiobutton enable the textbox
        private void cName_CheckedChanged(object sender, EventArgs e)
        {
            input_tbox.Enabled = true;
        }

        private void mNumber_CheckedChanged(object sender, EventArgs e)
        {
            input_tbox.Enabled = true;
        }

        private void priceTag_CheckedChanged(object sender, EventArgs e)
        {
            input_tbox.Enabled = true;
        }

        private void sellStock_CheckedChanged(object sender, EventArgs e)
        {
            input_tbox.Enabled = true;
        }
    }
}
