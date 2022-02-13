namespace EnvVarManager {
public partial class Program {
	public static void Main(string[] args) {
		// check to see if the program was called empty
		if (args.Length == 0) {
			Blank($"No arguments passed.");
		} else if (args[0] == "get") {
			Get(args);
		} else if (args[0] == "list") {
			List(args);
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
