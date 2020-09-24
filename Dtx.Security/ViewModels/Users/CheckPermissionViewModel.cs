namespace ViewModels.Users
{
	public class CheckPermissionViewModel : object
	{
		public CheckPermissionViewModel() : base()
		{
		}

		// **********
		public string Token { get; set; }
		// **********

		// **********
		public string ApplicationName { get; set; }
		// **********

		// **********
		public string ApplicationEntityName { get; set; }
		// **********

		// **********
		public string ApplicationEntityPath { get; set; }
		// **********
	}
}
