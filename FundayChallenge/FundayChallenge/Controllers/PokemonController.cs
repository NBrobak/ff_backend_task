using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FundayChallenge.Models;

namespace FundayChallenge.Controllers
{
    [Route("api/[controller]")]
    public class PokemonController : Controller
    {
		private readonly PokemonContext _context;

		public PokemonController(PokemonContext context)
		{
			_context = context;
		}

        [HttpGet]
        public APIResult Get()
        {
			//Pokemon[] pokemons = new Pokemon[] {
			//    new Pokemon{ Id = 0, Name = "Growlithe", Evolution = 0, Types = new List<string>{ "Fire" }, IsLegendary = false},
			//    new Pokemon{ Id = 0, Name = "Arcanine", Evolution = 1, Types = new List<string>{ "Fire" }, IsLegendary = false} };

			IEnumerable<Pokemon> pokemons = _context.Pokemons;
            APIResult result = new APIMultiResult(pokemons);

            return result;
        }
        
        [HttpGet("{id}")]
        public APIResult Get(int id)
        {
			//Pokemon pokemon = new Pokemon { Id = 0, Name = "Growlithe", Evolution = 0, Types = new List<string> { "Fire" }, IsLegendary = false };

			Pokemon pokemon = _context.Find<Pokemon>(id);

			if (pokemon == null)
			{
				return new APISingleResult("404: Pokemon not found.");
			}

			APIResult result = new APISingleResult(pokemon);

            return result;
        }
        
        [HttpPost]
        public int Post([FromBody]Pokemon value)
        {


            return 0;
        }
    }
}
