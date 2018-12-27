using System;
using System.Collections.Generic;
using System.Linq;
using app.models;

namespace app
{
    public class Nullable
    {

        static List<Customer> customers = new List<Customer> { new Customer() };
        public  Nullable<int> FooBar()
        {
            int numbo = customers[0].Orders.Count();
            Nullable<int> vargo = 1;

            //////////////////
            

            return vargo;
        }
    }
}