namespace Dtx
{
	public static class String
	{
		static String()
		{
		}

		public static string Fix(this string text)
		{
			if (text == null)
			{
				return string.Empty;
			}

			text = text.Trim();

			if (text == string.Empty)
			{
				return string.Empty;
			}

			while (text.Contains("  "))
			{
				text =
					text.Replace("  ", " ");
			}

			return text;
		}
	}
}
