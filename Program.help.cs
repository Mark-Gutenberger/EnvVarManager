using System;
using System.IO;
using System.Linq;

namespace EnvVarManager {
public partial class Program {
	public static void Help() {
		string execPath = AppDomain.CurrentDomain.BaseDirectory;
		Console.WriteLine($"\r\nExecutable location: \r\n{indent()}{execPath}EnvVarManager.exe\r\n");
		Console.WriteLine($"Usage: EnvVarManager.exe <command> [<args>]");
		Console.WriteLine($"\r\n{indent()}set <name> <value> [<args>]");
		Console.WriteLine($"{indent()}Valid arguments:");
		Console.WriteLine($"{indent(2)}--force-overwrite [optional]");
		Console.WriteLine($"{indent(3)}Forces an overwrite of an existing variable, instead of appending the value.");
		Console.WriteLine($"{indent()}ex: ");
		Console.WriteLine($"{indent(2)}EnvVarManager set exampleVar ExampleVal01234");
		Console.WriteLine($"{indent(2)}EnvVarManager set exampleVar ExampleVal0123456789 --force-overwrite");
		Console.WriteLine($"{indent(2)}EnvVarManager set path C:\\Program Files\\MyNeatApp\\bin\\");
		Console.WriteLine($"{indent(2)}NOTE: \"set\" appends any existing values.");
		Console.WriteLine($"{indent(2)}If you wish to replace the variable entirely, pass the --force-overwrite flag.");
		Console.WriteLine($"{indent(2)}Be EXTREMELY CAUTIOUS when passing a force option. THERE IS NO WAY TO GO BACK.");
		Console.WriteLine($"\r\n{indent()}get <name>");
		Console.WriteLine($"\r\n{indent()}list [<args>]");
		Console.WriteLine($"\r\n{indent()}delete <name>");
		Console.WriteLine($"{indent()}help");
		return;
	}
}
}
