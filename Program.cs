using System;
using System.Reflection;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var machineName = Environment.MachineName;
			var user = Environment.UserName;
			var assemblyPath = Assembly.GetExecutingAssembly().Location;
			Console.Write($"Tested by {user}@{machineName} at {assemblyPath}");
		}
	}
}
