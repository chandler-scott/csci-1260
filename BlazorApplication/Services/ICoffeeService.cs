using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;

public interface ICoffeeService
{ 
    Task<List<Coffee>> GetAllCoffeesAsync();
    Task<List<Coffee>> GetHotCoffeesAsync();
    Task<List<Coffee>> GetIcedCoffeesAsync();
    Task<Coffee> GetRandomCoffeeAsync();
}
