using System;
using System.IO;
using System.Text;

namespace EnvVarManager {
public class Program {
	public static void Main(string[] args) {
		string PATH_value = Environment.GetEnvironmentVariable("PATH");
		try {
			PATH_value = PATH_value.Replace(";", ";\r\n");
			Console.WriteLine($"PATH_: \r\n {PATH_value}");
			File.WriteAllText($"PATH.txt", PATH_value);
		} catch (Exception e) {
			Console.Error.WriteLine(
				$"PATH is not found. There is probably something wrong with your environment.\r\n");
			Console.WriteLine($"Error:  {e.Message}");
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
		// 		value = Environment.GetEnvironmentVariable("Test1", enumValue);
		// 		Console.WriteLine(
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
	}
}
}
