using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion {
	internal class Arena {
		public object[] Fighters { get; private set; }

		public Arena() { 
			Fighters = new object[] { new Robot(), new Robot(), new TrainingDummy() };
		}

		public void NextBattle() {
			//loop through and battle
		}
	}

	internal class Robot {
		public int Health { get; private set; }

		public Robot() {
			Health = 100;
		}

		public void Attack(Robot target) {
			target.Health -= 10;
		}
	}

	internal class TrainingDummy {
		public int Health { get; private set; }

		public TrainingDummy() {
			Health = 50;
		}

		public void Attack() {
            Console.WriteLine("Does Nothing...");
        }
	}
}
