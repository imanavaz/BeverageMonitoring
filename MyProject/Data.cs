﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Data
    {
        public Data(string brand, string title, string price, string size, string quantity, string perL, string ifSale, string savedPrice, string barcode, string link)
        {
            Brand = brand;
            Title = title;
            Price = price;
            Size = size;
            Quantity = quantity;
            PerL = perL;
            IfSale = ifSale;
            SavedPrice = savedPrice;
            Barcode = barcode;
            Link = link;
            if(savedPrice != "0")
            {
                OriginalPrice = "$" + (Convert.ToDouble(price.Substring(1)) + Convert.ToDouble(savedPrice.Substring(1))).ToString();
            }
            else
            {
                OriginalPrice = "0";
            }
        }

        public Data()
        {

        }

        private string _Brand;
        public string Brand
        {
            get { return _Brand; }
            set { _Brand = value; }
        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private string _Price;
        public string Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        private string _Quantity;
        public string Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        private string _Size;
        public string Size
        {
            get { return _Size; }
            set { _Size = value; }
        }

        private string _PerL;
        public string PerL
        {
            get { return _PerL; }
            set { _PerL = value; }
        }

        private string _IfSale;
        public string IfSale
        {
            get { return _IfSale; }
            set { _IfSale = value; }
        }

        private string _SavedPrice;
        public string SavedPrice
        {
            get { return _SavedPrice; }
            set { _SavedPrice = value; }
        }

        private string _OriginalPrice;
        public string OriginalPrice
        {
            get { return _OriginalPrice; }
            set { _OriginalPrice = value; }
        }

        private string _Barcode;
        public string Barcode
        {
            get { return _Barcode; }
            set { _Barcode = value; }
        }

        private string _Link;
        public string Link
        {
            get { return _Link; }
            set { _Link = value; }
        }

        public override string ToString()
        {
            return "Brand: " + Brand + " Title: " + Title + " Price: " + Price + " Size: " + Size + " Size: " + Quantity + " Litre Price: " + PerL + " Sale?: " + IfSale + " Saved Price: " + SavedPrice + " Original Price: " + OriginalPrice + " Barcode: " + Barcode + " Product Link: " + Link;
        }
    }
}
