using System;
using System.IO;
using System.Text;

namespace EnvVarManager {
public partial class Program {
	public static void HelpMe() {
		Console.WriteLine("Usage: EnvVarManager.exe <command> [<args>]");
		Console.WriteLine("Commands:");
		Console.WriteLine("  set <name> <value>");
		Console.WriteLine("  get <name> [<args>]");
		Console.WriteLine("  list [<args>]");
		Console.WriteLine("  delete <name>");
		Console.WriteLine("  help");
		return;
	}
	public static void Main(string[] args) {
		// if no args are passed...
		if (args.Length == 0) {
			// yell at the user
			Console.WriteLine("No arguments passed.");
			HelpMe();
			// if args are passed...
		} else {
			// get the time for logging purposes
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
}

// If necessary, create it.
// if (value == null) {
// 	Environment.SetEnvironmentVariable("Test1", "Value1");
// 	toDelete = false;

// 	// Now retrieve it.
// 	value = Environment.GetEnvironmentVariable("Test1");
// }
// // Display the value.
// Console.WriteLine($"Test1: {value}\n");

// // Confirm that the value can only be retrieved from the process
// // environment block if running on a Windows system.
// if (Environment.OSVersion.Platform == PlatformID.Win32NT) {
// 	Console.WriteLine("Attempting to retrieve Test1 from:");
// 	foreach (EnvironmentVariableTarget enumValue in Enum.GetValues(
// 				 typeof(EnvironmentVariableTarget))) {
// 		value = Environment.GetEnvironmentVariable("Test1",
// enumValue); 		Console.WriteLine(
// 			$"   {enumValue}: {(value != null ? "found" : "not
// found")}");
// 	}
// 	Console.WriteLine();
// }

// // If we've created it, now delete it.
// if (toDelete) {
// 	Environment.SetEnvironmentVariable("Test1", null);
// 	// Confirm the deletion.
// 	if (Environment.GetEnvironmentVariable("Test1") == null)
// 		Console.WriteLine("Test1 has been deleted.");
// }
