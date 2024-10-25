using ClassLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Enum
{
    internal class Product
    {
        private double _id = 1;
        private double _price;

        public double Id { get; set; }
        public string Name { get; set; }
        public Types Type { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;

                }

                else
                {

                    throw new PriceMustBeGratherThanZeroException("Qiymet menfi ola bilmez!!");
                }
            }
        }

        public Product(string name, double price, Types type)
        {
            Id = _id++;
            Name = name;
            Price = price;
            Type = type;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Price: {Price}, Type: {Type}");
        }


    }
}
