using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPellets
{
    internal class Order
    {

        private static int _nextId; 
        
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateOnly OrderDate { get; set; } 
        public DateOnly DeliveryDate { get; set; }

        public WoodPellet WoodPellet { get; set; } 
        public Address DeliveryAddress { get; set; }
        //public Customer Customer {get; set;}


        //Constructor 

        //Jeg har endnu ikke tilføjet WoodPellet, Address og Customer i constructoren, før vi ved, hvordan de skal bruges.

        public Order(int amount, DateOnly orderDate, DateOnly deliveryDate)
        {
            orderDate = OrderDate;
            deliveryDate = DeliveryDate;
            Id = _nextId++; 
        }



    }
}
