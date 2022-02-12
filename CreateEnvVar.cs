using System;
using System.IO;

namespace EnvVarManager {
public class Program {
	public static void Main(string[] args) {
		// Console.WriteLine("Hello World!");
		bool toDelete = false;

		// string stdin = Console.ReadLine();

		// Check whether the environment variable exists.
		string value = Environment.GetEnvironmentVariable("Test1");
		// If necessary, create it.
		if (value == null) {
			Environment.SetEnvironmentVariable("Test1", "Value1");
			toDelete = false;

			// Now retrieve it.
			value = Environment.GetEnvironmentVariable("Test1");
		}
		// Display the value.
		Console.WriteLine($"Test1: {value}\n");

		// Confirm that the value can only be retrieved from the process
		// environment block if running on a Windows system.
		if (Environment.OSVersion.Platform == PlatformID.Win32NT) {
			Console.WriteLine("Attempting to retrieve Test1 from:");
			foreach (EnvironmentVariableTarget enumValue in Enum.GetValues(
						 typeof(EnvironmentVariableTarget))) {
				value = Environment.GetEnvironmentVariable("Test1", enumValue);
				Console.WriteLine(
					$"   {enumValue}: {(value != null ? "found" : "not found")}");
			}
			Console.WriteLine();
		}

		// If we've created it, now delete it.
		if (toDelete) {
			Environment.SetEnvironmentVariable("Test1", null);
			// Confirm the deletion.
			if (Environment.GetEnvironmentVariable("Test1") == null)
				Console.WriteLine("Test1 has been deleted.");
		}
	}
}
// The example displays the following output if run on a Windows system:
//      Test1: Value1
//
//      Attempting to retrieve Test1 from:
//         Process: found
//         User: not found
//         Machine: not found
//
//      Test1 has been deleted.
//
// The example displays the following output if run on a Unix-based system:
//      Test1: Value1
//
//      Test1 has been deleted.
}
