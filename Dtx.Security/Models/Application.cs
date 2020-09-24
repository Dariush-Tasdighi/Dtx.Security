namespace Models
{
	public class Application : Base.ExtraExtendedEntity
	{
		public Application() : base()
		{
		}

		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(Name = "IP Restricted")]

		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.DataDictionary),
		//	Name = "IsIPRestricted")]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsIPRestricted))]
		public bool IsIPRestricted { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsUrlRestricted))]
		public bool IsUrlRestricted { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Name))]

		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false)]

		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false,
		//	ErrorMessage = "You did not specify Name!")]

		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false,
		//	ErrorMessage = "You did not specify {0}!")]

		//[System.ComponentModel.DataAnnotations.Required
		//	(AllowEmptyStrings = false,
		//	ErrorMessageResourceType = typeof(Resources.ErrorMessages),
		//	ErrorMessageResourceName = "Required")]

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
			Name = nameof(Resources.DataDictionary.Description))]
		public string Description { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<ApplicationGroup> ApplicationGroups { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<ApplicationEntity> ApplicationEntities { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<ApplicationValidIP> ApplicationValidIPs { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<ApplicationValidUrl> ApplicationValidUrls { get; set; }
		// **********
	}
}
