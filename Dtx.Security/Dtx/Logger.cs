namespace Dtx
{
	public class Logger : object, ILogger
	{
		public enum Level : int
		{
			Trace = 0,
			Debug = 1,
			Information = 2,
			Warning = 3,
			Error = 4,
			Fatal = 5,
		}

		public Logger(Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor) : base()
		{
			//if (httpContextAccessor == null)
			//{
			//	throw new System.ArgumentNullException(nameof(httpContextAccessor));
			//}

			//HttpContextAccessor = httpContextAccessor;

			HttpContextAccessor =
				httpContextAccessor ?? throw new System.ArgumentNullException(nameof(httpContextAccessor));
		}

		protected Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; set; }

		protected virtual string GetErrorMessage(System.Exception exception)
		{
			System.Text.StringBuilder result = new System.Text.StringBuilder();

			System.Exception currentException = exception;

			while (currentException != null)
			{
				if (result.Length != 0)
				{
					result.Append(" - [Inner Exception]: ");
				}

				result.Append(currentException.Message);

				currentException = currentException.InnerException;
			}

			return result.ToString();
		}

		protected void Log
			(Level level,
			System.Type type,
			string message,
			System.Exception exception = null,
			System.Collections.Hashtable parameters = null)
		{
			if (string.IsNullOrWhiteSpace(message))
			{
				return;
			}

			// **************************************************
			string currentCultureName =
				System.Threading.Thread.CurrentThread.CurrentCulture.Name;

			System.Globalization.CultureInfo newCultureInfo =
				new System.Globalization.CultureInfo(name: "en-US");

			System.Globalization.CultureInfo currentCultureInfo =
				new System.Globalization.CultureInfo(currentCultureName);

			System.Threading.Thread.CurrentThread.CurrentCulture = newCultureInfo;
			// **************************************************

			System.Text.StringBuilder result = new System.Text.StringBuilder();

			if ((HttpContextAccessor != null) &&
				(HttpContextAccessor.HttpContext != null) &&
				(HttpContextAccessor.HttpContext.Connection != null))
			{
				var remoteIpAddress =
					HttpContextAccessor.HttpContext.Connection.RemoteIpAddress;

				if (remoteIpAddress != null)
				{
					result.Append($"<ip>{ remoteIpAddress }</ip>");
				}
			}

			if ((HttpContextAccessor != null) &&
				(HttpContextAccessor.HttpContext != null) &&
				(HttpContextAccessor.HttpContext.Connection != null))
			{
				string path =
					HttpContextAccessor.HttpContext.Request.Path;

				if (string.IsNullOrWhiteSpace(path) == false)
				{
					result.Append($"<path>{ path }</path>");
				}

				string referer =
					HttpContextAccessor.HttpContext.Request.Headers["Referer"];

				if (string.IsNullOrWhiteSpace(referer) == false)
				{
					result.Append($"<httpReferrer>{ referer }</httpReferrer>");
				}
			}

			if (string.IsNullOrWhiteSpace(message) == false)
			{
				result.Append($"<message>{ message }</message>");
			}

			if (exception != null)
			{
				result.Append($"<errorMessages>{ GetErrorMessage(exception) }</errorMessages>");
			}

			if ((parameters != null) && (parameters.Count != 0))
			{
				result.Append("<parameters>");

				foreach (System.Collections.DictionaryEntry currentEntry in parameters)
				{
					if (currentEntry.Key != null)
					{
						result.Append("<parameter>");

						result.Append($"<key>{ currentEntry.Key }</key>");

						if (currentEntry.Value == null)
						{
							result.Append($"<value>NULL</value>");
						}
						else
						{
							result.Append($"<value>{ currentEntry.Value }</value>");
						}

						result.Append("</parameter>");
					}
				}

				result.Append("</parameters>");
			}

			NLog.Logger logger =
				NLog.LogManager.GetLogger(name: type.ToString());

			switch (level)
			{
				case Level.Trace:
				{
					logger.Trace(exception, message: result.ToString());
					break;
				}

				case Level.Debug:
				{
					logger.Debug(exception, message: result.ToString());
					break;
				}

				case Level.Information:
				{
					logger.Info(exception, message: result.ToString());
					break;
				}

				case Level.Warning:
				{
					logger.Warn(exception, message: result.ToString());
					break;
				}

				case Level.Error:
				{
					logger.Error(exception, message: result.ToString());
					break;
				}

				case Level.Fatal:
				{
					logger.Fatal(exception, message: result.ToString());
					break;
				}
			}

			// **************************************************
			System.Threading.Thread.CurrentThread.CurrentCulture = currentCultureInfo;
			// **************************************************
		}

		public void LogTrace
			(System.Type type, string message, System.Collections.Hashtable parameters = null)
		{
			Log(level: Level.Trace, type: type, message: message, exception: null, parameters: parameters);
		}

		public void LogDebug
			(System.Type type, string message, System.Collections.Hashtable parameters = null)
		{
			Log(level: Level.Debug, type: type, message: message, exception: null, parameters: parameters);
		}

		public void LogInformation
			(System.Type type, string message, System.Collections.Hashtable parameters = null)
		{
			Log(level: Level.Information, type: type, message: message, exception: null, parameters: parameters);
		}

		public void LogWarning
			(System.Type type, string message, System.Collections.Hashtable parameters = null)
		{
			Log(level: Level.Warning, type: type, message: message, exception: null, parameters: parameters);
		}

		public void LogError
			(System.Type type, string message = null, System.Collections.Hashtable parameters = null)
		{
			Log(level: Level.Error, type: type, message: message, exception: null, parameters: parameters);
		}

		public void LogError
			(System.Type type, System.Exception exception, string message = null, System.Collections.Hashtable parameters = null)
		{
			Log(level: Level.Error, type: type, message: message, exception: exception, parameters: parameters);
		}

		public void LogFatal
			(System.Type type, System.Exception exception, string message = null, System.Collections.Hashtable parameters = null)
		{
			Log(level: Level.Fatal, type: type, message: message, exception: exception, parameters: parameters);
		}
	}
}
