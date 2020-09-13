namespace Data.Tools
{
	public class Options : object
	{
		public Options() : base()
		{
		}

		// **********
		public bool InMemoryDatabase { get; set; }
		// **********

		// **********
		public string ConnectionString { get; set; }
		// **********
	}
}
