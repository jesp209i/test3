//Hvad er der galt her iht. S i SOLID?

using System;
using System.IO;
using test3;

namespace Solid.SingleResponsibility
{
	class Srp : IPrinciple
	{
		public string Principle()
		{
			return "Single Responsibility";
		}
	}


	public class Customer
	{
		// no database responsibility in customer class
	}

	public class CustomerRepository
    {
        private readonly Database _database;

        public CustomerRepository(Database database)
        {
            _database = database;
        }

		public void Add(Customer customer)
        {
			try
			{
				_database.Add();
			}
			catch (Exception ex)
            {
				// Error management
            }
        }
    }
}