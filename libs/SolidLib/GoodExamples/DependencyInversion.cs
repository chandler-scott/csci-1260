namespace SolidLib_Good;

public interface IFighter {
    int Health { get; set;}
    void Attack(IFighter target);
}

public class Arena {
    public IFighter[] Fighters { get; private set; }

    public Arena() {
        Fighters = new IFighter[] { new Robot(), new Robot(), new TrainingDummy() };
    }

    public void NextBattle() {
        // Loop through and battle
    }
}

public class Robot : IFighter {
    public int Health { get; set; }

    public Robot() {
        Health = 100;
    }

    public void Attack(IFighter target) {
        // Check if target is not null and has a health greater than zero
        if (target != null && target.Health > 0) {
            target.Health -= 10;
        }
    }
}

public class TrainingDummy : IFighter {
    public int Health { get; set; }

    public TrainingDummy() {
        Health = 50;
    }

    public void Attack(IFighter target) {
        Console.WriteLine("Does Nothing...");
    }
}
