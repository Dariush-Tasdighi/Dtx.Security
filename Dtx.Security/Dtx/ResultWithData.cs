namespace Dtx
{
	public class ResultWithData<T> : Result
	{
		public ResultWithData() : base()
		{
		}

		// **********
		public T Data { get; set; }
		// **********
	}
}
