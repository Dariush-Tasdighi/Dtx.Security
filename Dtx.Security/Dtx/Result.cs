namespace Dtx
{
	public class Result : object
	{
		public Result() : base()
		{
		}

		// **********
		public bool IsSuccessful { get; set; }
		// **********

		// **********
		public int ErrorCode { get; set; }
		// **********

		// **********
		public string ErrorMessage { get; set; }
		// **********
	}
}
