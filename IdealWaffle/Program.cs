﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace IdealWaffle
{
	public static class Program
	{
		public static void Main()
		{
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseIISIntegration()
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}