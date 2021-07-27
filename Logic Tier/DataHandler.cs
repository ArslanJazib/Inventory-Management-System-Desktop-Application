using System.Collections.Generic;
using System.Text.RegularExpressions;
using DataTier;
namespace LogicTier
{
    public class DataHandler
    {
        public static int counter = 0;//To loop through list by incrementing through MobileData form
        public static int total = 0;//To have the total number of phones currently in the file
        static List<Mobile> temporaryList = new List<Mobile>();
        public DataHandler()
        {
            //Loading all the content in the file into the list and stroing the total count in total
            FileHandler fileHandler = new FileHandler();
            temporaryList = fileHandler.LoadData();
            total = temporaryList.Count;
        }
        public byte InputValidation(string name, string number, string price,string stock)
        {
            string nameModel_pattern = @"(^[0-9A-Za-z ]+$)";//Regular Expression Name and Model can be of alphanumeric characters
            string priceStock_pattern = @"(^[0-9]+$)";//Regular Expression price & stock can be of digits between 0 & 9
            Match checkName = Regex.Match(name, nameModel_pattern);
            Match checkNumber = Regex.Match(number, nameModel_pattern);
            Match checkPrice = Regex.Match(price, priceStock_pattern);
            Match checkStock= Regex.Match(stock, priceStock_pattern);
            //If all inputs are correct
            if (checkName.Success && checkNumber.Success && checkPrice.Success && checkStock.Success)
            {
                return 1;
            }
            //If name is incorrect
            else if (checkName.Success != true && checkNumber.Success == true && checkPrice.Success == true && checkStock.Success == true)
            {
                return 2;
            }
            //If model is incorrect
            else if (checkName.Success == true && checkNumber.Success != true && checkPrice.Success == true && checkStock.Success == true) 
            {
                return 3;
            }
            //If price is incorrect
            else if (checkName.Success == true && checkNumber.Success == true && checkPrice.Success != true && checkStock.Success == true)
            {
                return 4;
            }
            //If stock is incorrect
            else if(checkName.Success == true && checkNumber.Success == true && checkPrice.Success != true && checkStock.Success != true)
            {
                return 5;
            }
            //If every input is incorrect
            else
            {
                return 6;
            }
        }
        public byte InputValidation(string input, byte choice)
        {
            string nameModel_pattern = @"(^[0-9A-Za-z ]+$)";//Regular Expression Name and Model can be of alphanumeric characters
            string priceStock_pattern = @"(^[0-9]+$)";//Regular Expression price and stock can be of digits between 0 & 9
            //If user updates name
            if (choice == 1)
            {
                Match checkName = Regex.Match(input, nameModel_pattern);
                if (checkName.Success)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            //If user updates number
            else if (choice == 2)
            {
                Match checkNumber = Regex.Match(input, nameModel_pattern);
                if (checkNumber.Success)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            //If user updates price
            else if (choice == 3) 
            {
                Match checkPrice = Regex.Match(input, priceStock_pattern);
                if (checkPrice.Success)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            //If user updates stock
            else
            {
                Match checkStock = Regex.Match(input, priceStock_pattern);
                if (checkStock.Success)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

        }
        public void LoadDataGird(ref string companyName, ref string modelNumber, ref string price, ref string stock)
        {
            //Initialzing each phone's data to refrence varaibles for loading the grid
            if (counter < temporaryList.Count)
            {
                companyName = temporaryList[counter].CompanyName;
                modelNumber = temporaryList[counter].ModelNumber;
                price = temporaryList[counter].Price;
                stock = temporaryList[counter].Stock;
            }
        }
        public void StoreDataGird(string companyName, string modelNumber, string price, string stock)
        {
            FileHandler fileHandler = new FileHandler();
            Mobile mobile = new Mobile();
            // stroing the object data  passed from MobileData into the text file
            mobile.CompanyName = companyName;
            mobile.ModelNumber = modelNumber;
            mobile.Price = price;
            mobile.Stock = stock;
            fileHandler.StoreData(mobile);

        }
    }
}
