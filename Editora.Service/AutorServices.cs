using Editora.Domain;
using Editora.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Editora.Service
{
    public class AutorServices
    {
        private AutorRepository Repository { get; set; }

        public AutorServices(AutorRepository repository)
        {
            this.Repository = repository;
        }

        public List<Autor> GetAll()
        {
            return Repository.GetAll();
        }

        public Autor GetAutorById(int id)
        {
            return Repository.GetAutorById(id);
        }

        public void Save(Autor autor)
        {

            this.Repository.Save(autor);
        }

        public void Delete(int id)
        {
            Repository.Delete(id);
        }

        public void Update(int id, Autor aluno)
        {
            Repository.Update(id, aluno);
        }

    }
}
