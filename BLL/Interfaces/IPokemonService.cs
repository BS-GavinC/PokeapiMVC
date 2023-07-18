using DAL.Entities;

namespace BLL.Interfaces;

public interface IPokemonService
{
    Task<List<PokeResult>> GetAll();

    Task<Pokemon?> GetById(int id);
}