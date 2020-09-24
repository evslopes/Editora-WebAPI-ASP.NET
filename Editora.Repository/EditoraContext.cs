using Editora.Domain;
using Editora.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Editora.Repository
{
    public class EditoraContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public static readonly ILoggerFactory _loggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public EditoraContext(DbContextOptions<EditoraContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new AutorMap());
            modelBuilder.ApplyConfiguration(new LivroMap());


            base.OnModelCreating(modelBuilder);

        }

        public class EditoraContextFactory : IDesignTimeDbContextFactory<EditoraContext>
        {
            public EditoraContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<EditoraContext>();
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AtLivros;Trusted_Connection=True;MultipleActiveResultSets=true");

                return new EditoraContext(optionsBuilder.Options);

            }
        }



    }
}
