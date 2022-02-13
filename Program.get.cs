using System;
using System.IO;

namespace EnvVarManager {
public partial class Program {
	public static void Get(string[] args) {
		string EnvVarName = args[1];
		try {
			string EnvVarVal = Environment.GetEnvironmentVariable(EnvVarName);
			EnvVarVal = EnvVarVal.Replace(";", ";\r\n");
			Console.WriteLine($"Name: {EnvVarName} \r\nValue: \r\n{EnvVarVal}");
			File.WriteAllText($"{EnvVarName}_{now}.txt", EnvVarVal);
		} catch (Exception /*error*/) {
			Console.Error.WriteLine($"Error: enviromental variable \"{EnvVarName}\" not found.");
			// Console.WriteLine($"Error: {error.Message}");
		}
	}
}
}
