using System.Security.AccessControl;
using TapLib;

static void PrintCurrentPositions(List<(string, double)> values) 
{
    var orderedList = values.OrderByDescending(item => item.Item2).ToList();

    foreach (var item in orderedList)
    {
        if (item.Item2 >= 30)
        {
            Console.WriteLine($"{item.Item1}: FINISHED!");
        }
        else 
        {
            Console.WriteLine($"{item.Item1}: {item.Item2}");
        }
    }
}

Sprinter spr0 = new() { Name = "Greg", Speed = 3 };
Sprinter spr1 = new() { Name = "Gio", Speed = 8 };
Sprinter spr2 = new() { Name = "George", Speed = 4 };
Sprinter spr3 = new() { Name = "Guy", Speed = 1 };

List<Sprinter> sprinters = new() { spr0, spr1, spr2, spr3 };

Race race = new(30);
race.Sprinters = sprinters;
race.RaceCompleted += (sender, message) => Console.WriteLine(message);
race.SprinterFinished += (sender, message) => Console.WriteLine(message);
race.PositionUpdate += (sender, message) => PrintCurrentPositions(message);

race.SubscribeToSprinterEvents();

Console.WriteLine("Starting Race!");
await race.StartRace();

for(int i = 0; i < race.RaceStandings.Count; i++) 
{
    Console.WriteLine("RACE STANDINGS:");
    Console.WriteLine($"{i+1} {race.RaceStandings[i]}");
}