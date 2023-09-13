using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility {
	internal class Printer {

		public int SheetsRemaining { get; private set; }

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
}
