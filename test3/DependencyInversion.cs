//D IN SOLID

using System;
using System.IO;
using test3.Stuff;

class Dip : IPrinciple
{
	public string Principle()
	{
		return "Dependency Inversion";
	}

	internal class FileLogger : ILogger
	{
		public void Handle(string error)
		{
			File.WriteAllText(@"C:\Error.txt", error);
		}
	}
	internal class Customer
	{
		ILogger _logger;
        public Customer(ILogger logger)
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
	public interface ILogger
    {
		void Handle(string error);
    }
}