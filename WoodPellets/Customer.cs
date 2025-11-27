using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPellets
{
    public class Customer
    {
        static int _nextId;
        private int NewId;

        public int Id { get; } = ++_nextId;

        public string Name { get; set; }
        public string Phone { get; set; }

        public string Email { get; set; }

        public Customer(int nextId)

        {
            _nextId = nextId;
          
        }

    }
}

