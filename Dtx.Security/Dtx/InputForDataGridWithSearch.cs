namespace Dtx
{
	public class InputForDataGrid<T> : object
	{
		public InputForDataGrid() : base()
		{
		}

		// **********
		public T Search { get; set; }
		// **********

		// **********
		public int PageSize { get; set; }
		// **********

		// **********
		public int PageIndex { get; set; }
		// **********

		//// **********
		//public string SortName { get; set; }
		//// **********

		//// **********
		//public string SortDirection { get; set; }
		//// **********
	}
}
