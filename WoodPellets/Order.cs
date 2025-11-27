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
        public Customer Customer {get; set;}


        //Constructor 

        public Order(Customer customer, Address deliveryAddress, WoodPellet woodPellet, int amount, DateOnly orderDate, DateOnly deliveryDate)
        {

            customer = Customer; 
            deliveryAddress = DeliveryAddress; 
            woodPellet = WoodPellet; 
            orderDate = OrderDate;
            deliveryDate = DeliveryDate;
            Id = _nextId++; 
        }



    }
}
