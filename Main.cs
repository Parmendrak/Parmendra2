using UIKit;

namespace dertryrt
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			int dd = 7;
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
