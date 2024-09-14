using System;
using Microsoft.EntityFrameworkCore;

namespace AulaEntityFramework.Models
{
	// A classe de contexto de banco de dados
	// ou DbContext ´´e responsável por
	// mapear as classes que serão atreladas
	// às tabelas do banco de dados
	public class MyDbContext : DbContext
	{

		public MyDbContext(
			DbContextOptions options
		) : base(options)
		{ 

		}
			
		//Nesta sessão especificamos as 
		//Classes dos Model que serão espelhadas
		// em tabelas do BD

		public DbSet<Pessoa> Pessoas { get; set; }
		public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Time> Times { get; set; }
        public DbSet<TimePessoa> TimePessoas { get; set; }

    }
}