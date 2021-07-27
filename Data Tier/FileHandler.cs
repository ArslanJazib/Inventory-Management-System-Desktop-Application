using System;
using System.Collections.Generic;
using System.IO;
namespace DataTier
{
    public class FileHandler
    {
        static bool fileStatus = false;//To check if the file was accesed or not by the program
        List<Mobile> AllPhones = new List<Mobile>();//To hold the data of every phone
        //Reading all the data into the list
        public List<Mobile> LoadData()
        {
            StreamReader reader = new StreamReader("Mobile.txt");
            while (!reader.EndOfStream)
            {
                Mobile mobile = new Mobile();
                mobile.CompanyName = reader.ReadLine();
                mobile.ModelNumber = reader.ReadLine();
                mobile.Price = reader.ReadLine();
                mobile.Stock = reader.ReadLine();
                AllPhones.Add(mobile);
            }
            reader.Close();
            return AllPhones;
        }
        //Stroing all the data from the object into the file
        public void StoreData(Mobile mobile)
        {
            if (fileStatus == false)
            {
                StreamWriter temp = new StreamWriter("Mobile.txt");
                temp.Close();
            }
            StreamWriter writer = new StreamWriter("Mobile.txt", true);
            writer.WriteLine(mobile.CompanyName);
            writer.WriteLine(mobile.ModelNumber);
            writer.WriteLine(mobile.Price);
            writer.WriteLine(mobile.Stock);
            writer.Close();
            fileStatus = true;
        }
    }
}
