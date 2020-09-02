// Hvad er der galt her iht. O i SOLID?

using test3;

namespace Solid.OpenClosed
{
	class Ocp : IPrinciple
	{
		public string Principle()
		{
			return "Open for Extension, Closed for Modification";
		}
	}
	internal class Customer
	{
		public int Type;

		public virtual void Add(Database db)
		{
			db.Add();
		}
	}

	internal class NewCustomer : Customer
	{
		public override void Add(Database db)
		{
			// new cutomer logic
			base.Add(db);
		}
	}
	internal class ExistingCustomer : Customer
	{
		public override void Add(Database db)
		{
			// maybe existing customer logic
			db.AddExistingCustomer();
		}
	}

}