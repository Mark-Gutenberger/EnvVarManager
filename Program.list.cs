using System;
using System.Linq;
using System.IO;

namespace EnvVarManager {
public partial class Program {
	public static void List(string[] args) {
		try {
			string[] envVarsArr = Environment.GetEnvironmentVariables().Keys.Cast<string>().ToArray();
			string envVarsStr = string.Join("\r\n", envVarsArr);
			Console.WriteLine($"Environmental Variables:");
			foreach (string envVar in envVarsArr) {
				Console.WriteLine($"{indent()}{envVar}");
				File.WriteAllText($"AllEnvVars_{now}.txt", envVarsStr);
			}
		} catch (Exception error) {
			Console.Error.WriteLine($"Error: Unhandled error");
			Console.Error.WriteLine($"\"Program.List()\" was called, but returned null.");
			Console.WriteLine($"Error: {error.Message}");
			return;
		}
		return;
	}
}
}
