using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace SelfhostConsole
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var baseAddress = "http://localhost:9000/";

			using (WebApp.Start<Startup>(url: baseAddress))
			{
				Process.Start(baseAddress);
				Console.ReadLine();
			}
		}
	}
}