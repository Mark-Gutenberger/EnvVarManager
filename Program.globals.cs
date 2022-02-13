using System;
using System.Linq;

namespace EnvVarManager {
public partial class Program {
	// lets just set up a neat little indentation handler to make our life easier, yes?
	public static string indent(int indentWidth = 1) {
		string indent = string.Concat(Enumerable.Repeat("  ", indentWidth));
		return indent;
	}
	// alright, now lets set up a handler for if the program is called without any params
	public static void Blank(string error) {
		string execPath = AppDomain.CurrentDomain.BaseDirectory;
		Console.WriteLine($"Executable location: \r\n{indent()}{execPath}EnvVarManager.exe\r\n");
		Console.WriteLine($"Error: {error}\r\n");
		Console.WriteLine($"Usage: EnvVarManager.exe <command> [<args>]");
		Console.WriteLine($"Commands:");
		Console.WriteLine($"{indent()}set <name> <value>");
		Console.WriteLine($"{indent()}get <name> [<args>]");
		Console.WriteLine($"{indent()}list [<args>]");
		Console.WriteLine($"{indent()}delete <name>");
		Console.WriteLine($"{indent()}help");
		Console.WriteLine($"For more help run: \"EnvVarManager.exe help\"\r\n");
		return;
	}
	// parse local time to a string for logging purposes
	static DateTime nowDT = DateTime.Now;
	public static string now = nowDT.ToString("yyyy-MM-dd-HH-mm-ss");
}
}
