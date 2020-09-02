//I in SOLID


class Isp : IPrinciple
{
	public string Principle()
	{
		return "Interface Segregation";
	}


	// If we want to add more functionality, don't add to existing
	// interfaces, segregate them out.
	interface ICustomer // existing
	{
		void Add();
	}

	interface ICustomerImproved : ICustomer
	{
		void Read();
	}
}