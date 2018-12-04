using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FundayChallenge.Models
{
	public class PokemonContext : DbContext
	{
		public DbSet<Pokemon> Pokemons { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Pokemon>().HasKey("Id");
		}
	}
}
