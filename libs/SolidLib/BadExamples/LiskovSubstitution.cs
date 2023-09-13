namespace SolidLib_Bad;

/*
* Liskov Substitution Principle: 
* Functions that use base classes 
* must be able to use objects of derived classes without knowing it
*/

public class Apple {
	public virtual string GetColor() {
		return "Red";
	}
}

public class Orange : Apple {
	public override string GetColor() {
		return "Orange";
	}
}