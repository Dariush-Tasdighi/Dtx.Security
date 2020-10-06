namespace Dtx
{
	public class Result : object
	{
		public Result() : base()
		{
			ErrorMessages =
				new System.Collections.Generic.List<string>();

			WarningMessages =
				new System.Collections.Generic.List<string>();

			InformationMessages =
				new System.Collections.Generic.List<string>();
		}

		// **********
		public bool IsSuccessful { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<string> ErrorMessages { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<string> WarningMessages { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<string> InformationMessages { get; set; }
		// **********

		// **********
		public virtual void AddErrorMessage(string message)
		{
			if (string.IsNullOrWhiteSpace(message))
			{
				return;
			}

			message = message.Fix();

			if (ErrorMessages.Contains(message))
			{
				return;
			}

			ErrorMessages.Add(message);
		}
		// **********

		// **********
		public virtual void AddWarningMessage(string message)
		{
			if (string.IsNullOrWhiteSpace(message))
			{
				return;
			}

			message = message.Fix();

			if (WarningMessages.Contains(message))
			{
				return;
			}

			WarningMessages.Add(message);
		}
		// **********

		// **********
		public virtual void AddInformationMessage(string message)
		{
			if (string.IsNullOrWhiteSpace(message))
			{
				return;
			}

			message = message.Fix();

			if (InformationMessages.Contains(message))
			{
				return;
			}

			InformationMessages.Add(message);
		}
		// **********
	}
}
