//L i SOLID

using System.Collections.Generic;
using test3.Stuff;

namespace Solid.Liskov
{
	class Lsp : IPrinciple
	{
		public string Principle()
		{
			return "Liskov Substitution";
		}
		class Enquiry : Customer
		{
			public override int Discount(int sales)
			{
				return this.BaseDiscount - (sales * 5);
			}

			/*** 
             * This method doesnt follow LSP because it is expected to be able to add to db.
			 ***
			
            public override void Add(Database db)
            {
                throw new Exception("Not allowed");
            }
			*/
		}
		public class GoldCustomer : Customer
		{
			public override int Discount(int sales)
			{
				return BaseDiscount - sales - 100;
			}
		}

		public class SilverCustomer : Customer
		{
			public override int Discount(int sales)
			{
				return BaseDiscount - sales - 50;
			}
		}
		class ViolatingLiskovs
		{
			public void ParseCustomers()
			{
				var database = new Database();
				var customers = new List<Customer>
				   {
					   new GoldCustomer(),
					   new SilverCustomer(),
					   new Enquiry() // This is valid
	               };


				foreach (Customer c in customers)
				{
					// Enquiry.Add() will throw an exception here!
					c.Add(database);
				}
			}
		}
	}
}
