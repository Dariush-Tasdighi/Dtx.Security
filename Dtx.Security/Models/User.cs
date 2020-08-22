namespace Models
{
	public class User : Base.ExtraExtendedEntity
	{
		public User() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Type))]
		public Enums.UserType Type { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsExpirable))]
		public bool IsExpirable { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ExpireDateTime))]
		public System.DateTime? ExpireDateTime { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsIPRestricted))]
		public bool IsIPRestricted { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.FullName))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.FULL_NAME,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Username))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.USERNAME,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Password))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.Required))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.PASSWORD,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.EmailAddress))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.EMAIL_ADDRESS,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string EmailAddress { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.NationalCode))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.NATIONAL_CODE,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string NationalCode { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.CellPhoneNumber))]

		[System.ComponentModel.DataAnnotations.MinLength
			(length: Constant.Length.MIN_CELL_PHONE_NUMBER,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MinLength))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.MAX_CELL_PHONE_NUMBER,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string CellPhoneNumber { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.RegisterIP))]

		[System.ComponentModel.DataAnnotations.MaxLength
			(length: Constant.Length.IP,
			ErrorMessageResourceType = typeof(Resources.ErrorMessages),
			ErrorMessageResourceName = nameof(Resources.ErrorMessages.MaxLength))]
		public string RegisterIP { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Description))]
		public string Description { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<LoginLog> LoginLogs { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<Membership> Memberships { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<UserValidIP> UserValidIPs { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<CheckPermissionLog> CheckPermissionLogs { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<UserPasswordHistory> UserPasswordHistories { get; set; }
		// **********

		// **********
		// **********
		// **********
		public System.Collections.Generic.IList<User> VerifiedUsers { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<Application> VerifiedApplications { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<UserValidIP> VerifiedUserValidIPs { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<ApplicationEntity> VerifiedApplicationEntities { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<ApplicationValidIP> VerifiedApplicationValidIPs { get; set; }
		// **********

		// **********
		public System.Collections.Generic.IList<ApplicationValidUrl> VerifiedApplicationValidUrls { get; set; }
		// **********
		// **********
		// **********
	}
}
