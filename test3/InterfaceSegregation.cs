//I in SOLID


using test3.Stuff;

class Isp : IPrinciple
{
	public string Principle()
	{
		return "Interface Segregation";
	}

	interface ICustomer
	{
		void Add();
	}

	interface ICustomerImproved : ICustomer
	{
		// 'void Add()' was removed from this interface, and instead inherited from ICustomer
		void Read();
	}
}