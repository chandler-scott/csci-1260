namespace SolidLib_Good;

public class Device 
{
	public int SheetsRemaining { get; set; }
	public Device()
	{
		SheetsRemaining = 0;
	}

	public Device(int sheetsToLoad)
	{
		SheetsRemaining = sheetsToLoad;
	}

	public void LoadSheets(int sheets) {
		SheetsRemaining += sheets;
	}
}

public class Printer : Device
{
	public Printer(int sheetsToLoad) : base(sheetsToLoad) { }
	public Printer() : base() {}

	public void Print(int pages) {
		//Ensure there is enough paper
		if (pages <= SheetsRemaining) {
			Console.WriteLine("Printing...");
			SheetsRemaining -= pages;
		}
	}
}

public class FaxMachine : Device 
{
	public FaxMachine(int sheetsToLoad) : base(sheetsToLoad) { }

	public FaxMachine() : base() {}

	public void Fax() {
		Console.WriteLine("Faxing...");
	}
}

public class Scanner : Device 
{
	public Scanner(int sheetsToLoad) : base(sheetsToLoad) { }
	public Scanner() : base() {}

	public void Scan() {
		Console.WriteLine("Scanning...");
	}
}
