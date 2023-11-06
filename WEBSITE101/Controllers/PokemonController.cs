﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using WEBSITE101.Interface;
using WEBSITE101.Model;

namespace WEBSITE101.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonController(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemons>))]
        public IActionResult Index()
        {
              var poke =  _pokemonRepository.GetPokemons();
            
            if (poke.Count  < 1)
            {

                 ModelState.AddModelError("", "No Pokemons found");
                return BadRequest(ModelState);
            }
            return Ok(poke);
        }

        
    }
}