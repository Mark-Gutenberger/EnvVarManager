using System;
using System.Linq;

namespace EnvVarManager {
public partial class Program {
	public static string indent(int indentWidth) {
		string indent = string.Concat(Enumerable.Repeat("  ", indentWidth));
		return indent;
	}
	public static void Blank(string error) {
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
}
}
