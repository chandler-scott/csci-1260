using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

public class CoffeeService
{
    private readonly HttpClient _httpClient;
    public bool Initialized { get; set; }  = false;

    public CoffeeService()
    {
        _httpClient = new();
    }

    public List<Coffee> HotCoffees { get; private set; } = new List<Coffee>();
    public List<Coffee> IcedCoffees { get; private set; } = new List<Coffee>();
    public List<Coffee> AllCoffees { get; private set; } = new List<Coffee>();

    public async Task InitializeCoffees()
    {
        await GetHotCoffee();
        await GetIcedCoffee();

        AllCoffees.AddRange(HotCoffees);
        AllCoffees.AddRange(IcedCoffees);

        Initialized = true;
    }

    private async Task GetHotCoffee()
    {
        var response = await _httpClient.GetStringAsync("https://api.sampleapis.com/coffee/hot");
        HotCoffees = JsonSerializer.Deserialize<List<Coffee>>(response) ?? new List<Coffee>();
    }

    private async Task GetIcedCoffee()
    {
        var response = await _httpClient.GetStringAsync("https://api.sampleapis.com/coffee/iced");
        IcedCoffees = JsonSerializer.Deserialize<List<Coffee>>(response) ?? new List<Coffee>();
    }
}
