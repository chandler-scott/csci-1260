namespace SolidLib_Bad;

/*
* Single Responsibility: 
* A class should have one, and only one, reason to change; in other words,
* a class should have only one responsibility.
*/

public class Printer {

		public int SheetsRemaining { get; set; }

		public Printer() {
			SheetsRemaining = 0;
		}

		public Printer(int sheetsToLoad) {
			SheetsRemaining = sheetsToLoad;
		}

		public void Print(int pages) {
			//Ensure there is enough paper
			if (pages <= SheetsRemaining) {
                Console.WriteLine("Printing...");
				SheetsRemaining -= pages;
            }
		}

		public void LoadSheets(int sheets) {
			SheetsRemaining += sheets;
		}

		public void Scan() {
			Console.WriteLine("Scanning...");
		}

		public void Fax() {
			Console.WriteLine("Faxing...");
		}

	}
