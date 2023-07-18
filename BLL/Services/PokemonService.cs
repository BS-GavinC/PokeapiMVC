using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repository;

namespace BLL.Services;

public class PokemonService : IPokemonService
{
    private readonly IPokemonRepository _pokemonRepository;

    public PokemonService(IPokemonRepository pokemonRepository)
    {
        _pokemonRepository = pokemonRepository;
    }

    public async Task<List<PokeResult>> GetAll()
    {
        return await _pokemonRepository.GetAll();
    }

    public async Task<Pokemon?> GetById(int id)
    {
        return await _pokemonRepository.GetById(id);
    }
}