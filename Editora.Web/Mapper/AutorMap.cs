using AutoMapper;
using Editora.Domain;
using Editora.Web.Models.Autor;

namespace Editora.Web.Mapper
{
    public class AutorMap : Profile
    {
        public AutorMap()
        {
            CreateMap<Autor, AutorViewModel>();
        }
    }
}
