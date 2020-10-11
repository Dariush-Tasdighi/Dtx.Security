namespace Dtx
{
	public class ResultForDataGrid<T> : Result<T>
	{
		public ResultForDataGrid() : base()
		{
		}

		// **********
		public int Count { get; set; }
		// **********
	}
}
