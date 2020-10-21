namespace Models.Learning
{
	public class BasketItem : object
	{
		public BasketItem() : base()
		{
		}

		// **********
		public int ProductPrice { get; set; }
		// **********

		// **********
		public int ProductCount { get; set; }
		// **********

		// **********
		public string ProductName { get; set; }
		// **********

		public void Plus()
		{
			if (ProductCount < 10)
			{
				ProductCount++;
			}
		}

		public void Minus()
		{
			if (ProductCount > 0)
			{
				ProductCount--;
			}
		}

		public int GetSubTotal()
		{
			int result =
				ProductPrice * ProductCount;

			if (ProductCount > 5)
			{
				result =
					(int)((decimal)(result * 95) / 100);
			}

			return result;
		}
	}
}
