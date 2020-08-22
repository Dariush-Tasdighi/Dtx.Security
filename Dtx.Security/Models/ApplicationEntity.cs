namespace Models
{
	public class ApplicationEntity : Base.ExtraExtendedEntity
	{
		public ApplicationEntity() : base()
		{
			Path = "/";

			AllowLogInputParameters = true;
			AllowLogOutputParameters = true;

			RequestType = Enums.RequestType.Get;
			AccessType = Enums.AccessType.Special;
		}

		// **********
		// **********
		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Application))]
		public System.Guid ApplicationId { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Application))]
		public Application Application { get; set; }
		// **********
		// **********
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
			Name = nameof(Resources.DataDictionary.RequestType))]
		public Enums.RequestType RequestType { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsSynced))]
		public bool IsSynced { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.AllowLogInputParameters))]
		public bool AllowLogInputParameters { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.AllowLogOutputParameters))]
		public bool AllowLogOutputParameters { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Name))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.GENERAL_NAME,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string Name { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Title))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.DISPLAY_NAME,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string Title { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Path))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.SITE_ABSOLUTE_PATH,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string Path { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Description))]
		public string Description { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<Permission> Permissions { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<CheckPermissionLog> CheckPermissionLogs { get; set; }
		// **********
	}
}
