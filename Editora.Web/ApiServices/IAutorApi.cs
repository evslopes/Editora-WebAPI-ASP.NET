using Editora.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Editora.Web.Models.Autor;

namespace Editora.Web.ApiServices
{
    public interface IAutorApi
    {
        Task<List<AutorViewModel>> GetAutors();
        Task<AutorViewModel> GetAutor(int id);
    }
}
