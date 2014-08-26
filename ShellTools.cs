using System;
using System.Threading;
using System.Diagnostics;

namespace XamStore.Android.Tests
{
	public class ShellTools
	{
		private const string WifiPackage = "Xamarin.AutomationTools";

		public ShellTools ()
		{

		}

		public void DisableWifi()
		{
			var info = new ProcessStartInfo ("~/Library/Developer/Xamarin/android-sdk-mac_x86/platform-tools/adb");
			var process = Process.Start (info);

			if (process == null)
				throw new NullReferenceException ("Null it's.");

			process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) => {
				Console.Write("ERROR: " + e.Data);
			};

			process.OutputDataReceived += (object sender, DataReceivedEventArgs e) => {
				Console.Write("DATA: " + e.Data);
			};
		}
	}
}

