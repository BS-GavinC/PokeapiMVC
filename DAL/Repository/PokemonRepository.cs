using System.Net.Http.Json;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repository;

public class PokemonRepository : IPokemonRepository
{
    public async Task<List<PokeResult>> GetAll()
    {
        using (HttpClient http = new HttpClient())
        {
            
            HttpResponseMessage response = await http.GetAsync("https://pokeapi.co/api/v2/pokemon?limit=1281");

            if (response.IsSuccessStatusCode)
            {
                Result result = await response.Content.ReadFromJsonAsync<Result>();

                return result.results;
            }
        }

        return new List<PokeResult>();
    }

    public async Task<Pokemon?> GetById(int id)
    {
        using (HttpClient http = new HttpClient())
        {
            HttpResponseMessage response = await http.GetAsync($"https://pokeapi.co/api/v2/pokemon/{id}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Pokemon>();
            }
        }
        
        return null;
    }

   
}