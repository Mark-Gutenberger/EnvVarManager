using System;
using System.IO;

namespace EnvVarManager {
public partial class Program {
	public static void Get(string[] args) {
		DateTime nowDT = DateTime.Now;
		string now = nowDT.ToString("yyyy-MM-dd-HH-mm-ss");
		string EnvVarName = args[1];
		string EnvVarVal = Environment.GetEnvironmentVariable(EnvVarName);
		try {
			EnvVarVal = EnvVarVal.Replace(";", ";\r\n");
			Console.WriteLine($"PATH_: \r\n {EnvVarVal}");
			File.WriteAllText($"{EnvVarName}_{now}.txt", EnvVarVal);
		} catch (Exception e) {
			Console.Error.WriteLine(
				$"Error: enviromental variable \"{EnvVarName}\" not found.");
			Console.WriteLine($"       {e.Message}");
		}
	}
}
}
