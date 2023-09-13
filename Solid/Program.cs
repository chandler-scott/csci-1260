// single responsibility
/*
Scanner scanner = new();
scanner.Scan();
*/


// liskov
SolidLib_Bad.Apple apple = new();
SolidLib_Bad.Orange orange = new();

Console.WriteLine("Apple color: " + apple.GetColor()); // Outputs "Apple color: Red"
// Now let's use an Orange object, but it behaves unexpectedly
Apple orangeAsApple = new Orange();
Console.WriteLine("Orange (as Apple) color: " + orangeAsApple.GetColor()); // Outputs "Orange (as Apple) color: Orange"

