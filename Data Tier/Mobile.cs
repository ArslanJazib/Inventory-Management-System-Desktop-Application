using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class Mobile
    {
        string companyName;
        string modelNumber;
        string price;
        string stock;

        public string CompanyName { get => companyName; set => companyName = value; }
        public string ModelNumber { get => modelNumber; set => modelNumber = value; }
        public string Price { get => price; set => price = value; }
        public string Stock { get => stock; set => stock = value; }
    }
}
