using System;
using System.Linq;
using System.IO;

namespace EnvVarManager {
public partial class Program {
	public static void List(string[] args) {
		try {
			string[] envVars = Environment.GetEnvironmentVariables().Keys.Cast<string>().ToArray();
			foreach (string envVar in envVars) {
				Console.WriteLine($"Enviromental Variables:");
				Console.WriteLine($"{indent()}{envVar}");
			}
		} catch (Exception error) {
			Console.Error.WriteLine($"Error: Unhandled error");
			Console.Error.WriteLine($"\"Program.List()\" was called, but returned null.");
			Console.WriteLine($"Error: {error.Message}");
		}
	}
}
}
