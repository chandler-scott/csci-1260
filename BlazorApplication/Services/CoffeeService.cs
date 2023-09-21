using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

public class CoffeeService : ICoffeeService
{
    private readonly HttpClient _httpClient;

    private List<Coffee> _allCoffees;
    private List<Coffee> _hotCoffees;
    private List<Coffee> _icedCoffees;

    private Random _random;
   
    public CoffeeService()
    {
        _httpClient = new();
        _allCoffees = new();
        _hotCoffees = new();
        _icedCoffees = new();
        _random = new();
    }

    public async Task<List<Coffee>> GetHotCoffeesAsync()
    {
        if (_hotCoffees.Count == 0) 
        {
            var response = await _httpClient.GetStringAsync("https://api.sampleapis.com/coffee/hot");
            _hotCoffees = JsonSerializer.Deserialize<List<Coffee>>(response) ?? new List<Coffee>();
            _allCoffees.AddRange(_hotCoffees);
        }
        return _hotCoffees;
    }

    public async Task<List<Coffee>> GetIcedCoffeesAsync()
    {
        if (_icedCoffees.Count == 0) 
        {
            var response = await _httpClient.GetStringAsync("https://api.sampleapis.com/coffee/iced");
            _icedCoffees = JsonSerializer.Deserialize<List<Coffee>>(response) ?? new List<Coffee>();
            _allCoffees.AddRange(_icedCoffees);
        }
        return _icedCoffees;
    }

    public async Task<List<Coffee>> GetAllCoffeesAsync() 
    {
        if (_hotCoffees.Count == 0 || _icedCoffees.Count ==0) 
        {
            await GetHotCoffeesAsync();
            await GetIcedCoffeesAsync();
        }
        return _allCoffees;
    }

    public async Task<Coffee> GetRandomCoffeeAsync() 
    {
        if (_hotCoffees.Count == 0 || _icedCoffees.Count == 0) 
        {
            await GetHotCoffeesAsync();
            await GetIcedCoffeesAsync();
        }


        return _allCoffees[
            _random.Next(_allCoffees.Count)
        ];
    }
}
