using DAL.Entities;

namespace DAL.Interfaces;

public interface IPokemonRepository
{
    Task<List<PokeResult>> GetAll();

    Task<Pokemon?> GetById(int id);

    
}