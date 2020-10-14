namespace Models.Learning
{
	public class TodoItem : object
	{
		public TodoItem() : base()
		{
		}

		// **********
		public bool IsDone { get; set; }
		// **********

		// **********
		public string Title { get; set; }
		// **********
	}
}
