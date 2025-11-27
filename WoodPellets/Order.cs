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

        

    }
}
