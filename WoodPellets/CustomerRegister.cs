using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodPellets
{
    public class CustomerRegister
    {
        public Customer customer { get; set; }

        private List<Customer> customers = new List<Customer>();

        //add
        public void AddCustomer(string name, string phone, string email)
        {
            int newId = customers.Count + 1;
        }

        //remove
        public Customer RemoveCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == id)
                {
                    customers.Remove(c);
                    return c;
                }
            }

            return new Customer(-1);
        }
        
        
        // get all
        public List<Customer> GetAllCustomers()
        {
            return customers;
        }


    }
}
