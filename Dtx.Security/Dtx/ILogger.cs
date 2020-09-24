namespace Dtx
{
	public interface ILogger
	{
		void LogTrace
			(System.Type type, string message, System.Collections.Hashtable parameters = null);

		void LogDebug
			(System.Type type, string message, System.Collections.Hashtable parameters = null);

		void LogInformation
			(System.Type type, string message, System.Collections.Hashtable parameters = null);

		void LogWarning
			(System.Type type, string message, System.Collections.Hashtable parameters = null);

		void LogError
			(System.Type type, string message = null, System.Collections.Hashtable parameters = null);

		void LogError
			(System.Type type, System.Exception exception, string message = null, System.Collections.Hashtable parameters = null);

		void LogFatal
			(System.Type type, System.Exception exception, string message = null, System.Collections.Hashtable parameters = null);
	}
}
