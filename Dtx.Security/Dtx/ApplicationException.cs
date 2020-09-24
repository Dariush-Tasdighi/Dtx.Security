namespace Dtx
{
	public class ApplicationException : System.ApplicationException
	{
		//public ApplicationException() : base()
		//{
		//}

		public ApplicationException(string message, int code) : base(message)
		{
			Code = code;
		}

		// **********
		public int Code { get; set; }
		// **********
	}
}
