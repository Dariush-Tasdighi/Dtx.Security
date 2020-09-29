namespace Models.Base
{
	public abstract class ExtendedEntity : Entity
	{
		public ExtendedEntity() : base()
		{
			//Ordering = 10000;
			UpdateDateTime = Utility.Now;
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsActive))]
		public bool IsActive { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Display
		//	(ResourceType = typeof(Resources.DataDictionary),
		//	Name = nameof(Resources.DataDictionary.Ordering))]
		//public int Ordering { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.UpdateDateTime))]
		public System.DateTime UpdateDateTime { get; set; }
		// **********
	}
}
