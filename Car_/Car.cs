﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_
{
    internal class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal TaxPersantage { get; set; }

        public decimal  CalculateTotal()
        {
            return Price + Price * TaxPersantage / 100;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Car \nBrand : " + Brand);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Model : " + Model);
            Console.WriteLine("price with taxes : " + CalculateTotal());
        }
        public Car(int iD, string model, string brand, decimal price)
        {
            ID=iD;
            Model=model;
            Brand=brand;
            Price=price;
        }
        


    }
}
