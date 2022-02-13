using System;
using System.Linq;
using System.IO;
using System.Reflection;

namespace EnvVarManager {
public partial class Program {
	// declare some basic globals
	public static string indent(int indentWidth) {
		string indent = string.Concat(Enumerable.Repeat("  ", indentWidth));
		return indent;
	}
	public static void HelpMe(string error) {
		string execPath = AppDomain.CurrentDomain.BaseDirectory;
		Console.WriteLine(
			$"Executable location: \r\n{indent(1)}{execPath}\\EnvVarManager.exe");
		Console.WriteLine($"Error: {error}");
		Console.WriteLine($"Usage: EnvVarManager.exe <command> [<args>]");
		Console.WriteLine($"Commands:");
		Console.WriteLine($"{indent(1)}set <name> <value>");
		Console.WriteLine($"{indent(1)}get <name> [<args>]");
		Console.WriteLine($"{indent(1)}list [<args>]");
		Console.WriteLine($"{indent(1)}delete <name>");
		Console.WriteLine($"{indent(1)}help");
		return;
	}
	public static void Main(string[] args) {
		// if no args are passed...
		if (args.Length == 0) {
			// yell at the user
			HelpMe($"No arguments passed.");
			// if args are passed...
		} else {
			// pass Get()
			Get(args);
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
