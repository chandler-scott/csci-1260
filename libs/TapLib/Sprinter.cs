namespace TapLib;

public class Sprinter
{
    public string Name { get; set; } = "Default";
    public double Speed { get; set; }
    public double CurrentPosition { get; set; }

    public event EventHandler<string> FinishedRace;


    public Sprinter() { }

    public Sprinter(string name, double speed) 
    {
        Name = name;
        Speed = speed;
    }

    public async Task RunSprint(double distance, int delay = 1000)
    {
        while (CurrentPosition < distance)
        {
            CurrentPosition += Speed * (delay / 1000.0); // Convert delay to seconds
            await Task.Delay(delay);
        }
        FinishedRace?.Invoke(this, Name);
    }
}
