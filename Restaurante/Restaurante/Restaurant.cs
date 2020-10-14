using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    class Restaurant
    {
        public int ticket;
        public int Ticket
        {
            get { return ticket; }
            set { ticket = value; }
        }
        public int table;
        public int Table
        {
            get { return table; }
            set { table = value; }
        }
        public string waiter;
        public string Waiter
        {
            get { return waiter; }
            set { waiter = value; }
        }
        public double people;
        public double People
        {
            get { return people; }
            set { people = value; }
        }
        int[] quantity = new int[5];
        public int[] Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        double[] price = new double[5];
        public double[] Price
        {
            get { return price; }
            set { price = value; }
        }
        string[] food = new string[5];
        public string[] Food
        {
            get { return food; }
            set { food = value; }
        }
        public double total;
        public double Total
        {
            get { return total; }
            set { total = value; }
        }


    }
}
