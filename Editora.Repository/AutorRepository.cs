using Editora.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Editora.Repository
{
    public class AutorRepository
    {
        private EditoraContext Context { get; set; }

        public AutorRepository(EditoraContext context)
        {
            this.Context = context;
        }

        public List<Autor> GetAll()
        {
            return Context.Autores.ToList();
        }

        public Autor GetAutorById(int id)
        {
            return Context.Autores.FirstOrDefault(x => x.Id == id);
        }

        public void Save(Autor Autor)
        {
            this.Context.Autores.Add(Autor);
            this.Context.SaveChanges();
        }

        public Autor GetAutorByEmail(string email)
        {
            return Context.Autores.FirstOrDefault(x => x.Email == email);
        }

        public void Delete(int id)
        {
            var Autor = Context.Autores.FirstOrDefault(x => x.Id == id);
            this.Context.Autores.Remove(Autor);
            this.Context.SaveChanges();
        }

        public void Update(int id, Autor Autor)
        {
            var AutorOld = Context.Autores.FirstOrDefault(x => x.Id == id);

            AutorOld.Nome = Autor.Nome;
            AutorOld.UltimoNome = Autor.UltimoNome;
            AutorOld.Email = Autor.Email;
            AutorOld.DataNascimento = Autor.DataNascimento;
            AutorOld.Livros = Autor.Livros;

            Context.Autores.Update(AutorOld);
            this.Context.SaveChanges();
        }
    }
}
