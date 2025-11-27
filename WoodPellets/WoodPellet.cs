using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPellets
{
    public class WoodPellet
    {
        private static int nextId = 1;
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Quality { get; set; } 
        public string Size { get; set; }
        public double Price { get; set; }
        public string Energy { get; set; }
        public string Humidity { get; set; }
        public int stock { get; set; }  
        public string info { get; set; }
        public WoodPellet(string brand, string quality, string size, double price, string energy, string humidity, int stock, string info)
        {
            Id = nextId++;
            Brand = brand;
            Quality = quality;
            Size = size;
            Price = price;
            Energy = energy;
            Humidity = humidity;
            this.stock = stock;
            this.info = info;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Brand: {Brand}, Quality: {Quality}, Size: {Size}, " +
                   $"Price: {Price}, Energy: {Energy}, Humidity: {Humidity}, " +
                   $"Stock: {stock}, Info: {info}";
        }

    }
}
