Dog dog = new Dog("Fido");
BankAccount account = new BankAccount("Chandler", 1_000_000);
Shape circle = new Circle();

Console.WriteLine($"Hello, {dog}!");
Console.WriteLine($"{account.getOwner()} has ${account.getBalance()}!");
Console.WriteLine($"Circle object outputs: {circle.getArea()}!");