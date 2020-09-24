using AutoMapper;
using Editora.Domain;
using Editora.Web.Models.Livro;


namespace Web.Mapper
{
    public class LivroMap : Profile
    {
        public LivroMap()
        {
            CreateMap<Livro, LivroViewModel>();
        }
    }
}
