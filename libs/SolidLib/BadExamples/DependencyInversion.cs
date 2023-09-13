namespace SolidLib_Bad;

/*
* Dependency Inversion Principle: 
* Depend upon abstractions, [not] concretions. Or in English:
* high-level modules should not depend on low-level modules. Both should
* depend on abstractions (e.g., interfaces or abstract classes)
*/

// Here, arena depends on concrete implentations of Robot and Training Dummy; instead,
// we can use interfaces or abstract classes to make this solution more clean
public class Arena {
	public object[] Fighters { get; private set; }

	public Arena() { 
		Fighters = new object[] { new Robot(), new Robot(), new TrainingDummy() };
	}

	public void NextBattle() {
		//loop through and battle
	}
}

public class Robot {
	public int Health { get; private set; }

	public Robot() {
		Health = 100;
	}

	public void Attack(Robot target) {
		target.Health -= 10;
	}
}

public class TrainingDummy {
	public int Health { get; private set; }

	public TrainingDummy() {
		Health = 50;
	}

	public void Attack() {
		Console.WriteLine("Does Nothing...");
	}
}