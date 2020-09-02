//D IN SOLID

class Dip : IPrinciple
{
	public string Principle()
	{
		return "Dependency Inversion";
	}

	internal class FileLogger : IFileLogger
	{
		public void Handle(string error)
		{
			File.WriteAllText(@"C:\Error.txt", error);
		}
	}
	internal class Customer
	{
		IFileLogger _logger;
        public Customer(IFileLogger logger)
        {
            this._logger = logger;
        }
		public void Add(Database db)
		{
			try
			{
				db.Add();
			}
			catch (Exception error)
			{
				_logger.Handle(error.ToString());
			}
		}
	}
	public interface IFileLogger
    {
		void Handle(string error);
    }
}