using System;
using System.Collections.Generic;
using System.Text;

namespace test3.Stuff
{
    public class Customer
    {
        public int BaseDiscount { get; set; }
        public virtual int Discount(int sales)
        {
            throw new NotImplementedException();
        }
        public void Add(Database db)
        {
            throw new NotImplementedException();
        }
    }
}
