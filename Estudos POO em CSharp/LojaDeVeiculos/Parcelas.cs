using System;
using System.Linq;
using ConsoleTables;

namespace LojaDeVeiculos;

public class Parcelas {

	public string ExibirTabela() {

		var table = new ConsoleTable("Parcelas", "Juros");

		table.AddRow("6" , "3%");
		table.AddRow("12", "6%");
		table.AddRow("18", "9%");
		table.AddRow("24", "12%");
		table.AddRow("30", "15%");
		table.AddRow("36", "18%");
		table.AddRow("42", "21%");
		table.AddRow("48", "24%");
		table.AddRow("54", "27%");
		table.AddRow("60", "30%");
		
		return table.ToString();
	}
}
