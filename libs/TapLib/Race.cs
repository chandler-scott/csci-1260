using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Timers;

namespace TapLib;

public class Race
{
    public List<Sprinter> Sprinters { get; set; }
    public string Title { get; set; } = "Default";
    public double Distance;
    public List<Sprinter> RaceStandings { get; set; } = new();


    public event EventHandler<string> SprinterFinished;
    public event EventHandler<string> RaceCompleted;
    public event EventHandler<List<(string, double)>> PositionUpdate;

    private static System.Timers.Timer s_stopwatch = new();

    public Race() 
    {
        Title = $"A {Distance}m Sprint";
        Sprinters = new();
        s_stopwatch = new(1000);
        s_stopwatch.Elapsed += UpdatePositions;
        s_stopwatch.AutoReset = true;
        s_stopwatch.Enabled = true;
    }

    public Race(double distance)
    {
        Distance = distance;
        Title = $"A {Distance}m Sprint";
        Sprinters = new();
        s_stopwatch = new(1000);
        s_stopwatch.Elapsed += UpdatePositions;
        s_stopwatch.AutoReset = true;
        s_stopwatch.Enabled = true;
    }

    public async Task StartRace() 
    {
        s_stopwatch.Start();
        var sprintTasks = Sprinters.Select(sprinter => sprinter.RunSprint(Distance)).ToList();

        // Wait for all sprinters to finish their races concurrently
        await Task.WhenAll(sprintTasks);

        RaceCompleted?.Invoke(this, "Race completed!");
        s_stopwatch.Stop();
        s_stopwatch.Dispose();
    }

    public void UpdatePositions(Object source, ElapsedEventArgs e)
    {
        List<(string, double)> Values = new();
        
        foreach (var sprint in Sprinters)
            Values.Add((sprint.Name, sprint.CurrentPosition));

        PositionUpdate?.Invoke(this, Values);
    }

    public void SubscribeToSprinterEvents()
    {
        foreach (var sprinter in Sprinters)
        {
            sprinter.FinishedRace += (sender, message) =>
            {
                if (sender is Sprinter sprinter)
                {
                    RaceStandings.Add(sprinter);
                    SprinterFinished?.Invoke(this, $"{sprinter.Name} completed the race!");
                }
            };   
        }
    }
}
