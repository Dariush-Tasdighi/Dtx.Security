namespace Dtx.Security.Client.Pages.Learning
{
	/// <summary>
	/// Note: Partial Class!
	/// Note: Do not inherit: object!
	/// </summary>
	public partial class Learn_1800
	{
		public Learn_1800() : base()
		{
			message = "Hello, World!";
		}

		//private string message;
		//private string message = "Hello, World!";

		private string message { get; set; }
		//private string message { get; set; } = "Hello, World!";

		private void DoSomething()
		{
			message = "Hello, World!";
		}
	}
}
