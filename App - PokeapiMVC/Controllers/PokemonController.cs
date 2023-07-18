using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PokeapiMVC.Controllers;

public class PokemonController : Controller
{

    private readonly IPokemonService _pokemonService;

    public PokemonController(IPokemonService pokemonService)
    {
        _pokemonService = pokemonService;
    }
    
    // GET
    public async Task<IActionResult> Index()
    {
        List<PokeResult> pokemons = await _pokemonService.GetAll();
        return View(pokemons);
    }

    public async Task<IActionResult> Details(int id)
    {
        Pokemon? pokemon = await _pokemonService.GetById(id);

        if (pokemon is not null)
        {
            return View(pokemon);
        }

        return RedirectToAction("NotFound");
    }

    public IActionResult NotFound()
    {
        return View();
    }
}