using System;
using System.IO;
using System.Linq;
using System.Collections;
using Microsoft.Win32;

namespace EnvVarManager {
public partial class Program {
	public static void Set(string[] args) {
		// string name = args[1];
		// string value = args[2];
		// // if (Environment.GetEnvironmentVariable(name) != null) {
		// // Environment.SetEnvironmentVariable(name, value);
		// // } else {
		// Environment.SetEnvironmentVariable(name, value, EnvironmentVariableTarget.User);
		// }
		////////////////////////////////////////////////////////////////////////////////////////////

		// Environment variable names for default, process, user, and machine targets.
		string defaultEnvVar = nameof(defaultEnvVar);
		string processEnvVar = nameof(processEnvVar);
		string userEnvVar = nameof(userEnvVar);
		string machineEnvVar = nameof(machineEnvVar);

		string dft = nameof(dft);
		string process = nameof(process);
		string user = nameof(user);
		string machine = nameof(machine);

		// Set the environment variable for each target.
		Console.WriteLine("Setting environment variables for each target...\n");
		// The default target (the current process).
		Environment.SetEnvironmentVariable(defaultEnvVar, dft);
		// The current process.
		Environment.SetEnvironmentVariable(processEnvVar, process, EnvironmentVariableTarget.Process);
		// The current user.
		Environment.SetEnvironmentVariable(userEnvVar, user, EnvironmentVariableTarget.User);
		// The local machine.
		Environment.SetEnvironmentVariable(machineEnvVar, machine, EnvironmentVariableTarget.Machine);

		string[] envVars = { defaultEnvVar, processEnvVar, userEnvVar, machineEnvVar };

		Console.WriteLine("Retrieving environment variables from the default target:");
		foreach (var envVar in envVars) {
			var value = Environment.GetEnvironmentVariable(envVar) ?? "(none)";
			Console.WriteLine($"   {envVar}: {value}");
		}
		// The process block.
		Console.WriteLine("\nRetrieving environment variables from the Process target:");
		foreach (var envVar in envVars) {
			var value = Environment.GetEnvironmentVariable(envVar, EnvironmentVariableTarget.Process) ?? "(none)";
			Console.WriteLine($"   {envVar}: {value}");
		}
		// The user block.
		Console.WriteLine("\nRetrieving environment variables from the User target:");
		foreach (var envVar in envVars) {
			var value = Environment.GetEnvironmentVariable(envVar, EnvironmentVariableTarget.User) ?? "(none)";
			Console.WriteLine($"   {envVar}: {value}");
		}
		// The machine block.
		Console.WriteLine("\nRetrieving environment variables from the Machine target:");
		foreach (var envVar in envVars) {
			var value = Environment.GetEnvironmentVariable(envVar, EnvironmentVariableTarget.Machine) ?? "(none)";
			Console.WriteLine($"   {envVar}: {value}");
		}
	}
}
}
