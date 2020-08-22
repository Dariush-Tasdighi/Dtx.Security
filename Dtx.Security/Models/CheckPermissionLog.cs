namespace Models
{
	public class CheckPermissionLog : Base.Entity
	{
		public CheckPermissionLog() : base()
		{
		}

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.User))]
		public System.Guid UserId { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.User))]
		public User User { get; set; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ApplicationEntity))]
		public System.Guid ApplicationEntityId { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ApplicationEntity))]
		public ApplicationEntity ApplicationEntity { get; set; }
		// **********
		// **********
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsSuccessful))]
		public bool Issuccessful { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Type))]
		public Enums.AccessType AccessType { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ApplicationEntityType))]
		public Enums.ApplicationEntityType Type { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.EntityPathName))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.SITE_ABSOLUTE_PATH,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string EntityPathName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.UserIP))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.IP,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string UserIP { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ApplicationIP))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.IP,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string ApplicationIP { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ApplicationUrl))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.SITE_ABSOLUTE_PATH,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string ApplicationUrl { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.InputParameters))]
		public string InputParameters { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.OutputParameters))]
		public string OutputParameters { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ErrorMessage))]
		public string ErrorMessage { get; set; }
		// **********
	}
}
