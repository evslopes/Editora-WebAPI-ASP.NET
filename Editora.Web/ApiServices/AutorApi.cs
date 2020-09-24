using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Editora.Web.Models.Autor;


namespace Editora.Web.ApiServices
{
    public class AutorApi : IAutorApi
    {
        private readonly HttpClient httpClient;

        public AutorApi()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:5001");
        }

        public async Task<AutorViewModel> GetAutor(int id)
        {
            var response = await httpClient.GetAsync($"api/Autors/" + id);

            var content = await response.Content.ReadAsStringAsync();

            var viewModel = JsonConvert.DeserializeObject<AutorViewModel>(content);

            return viewModel;
        }

        public async Task<List<AutorViewModel>> GetAutors()
        {
            var response = await httpClient.GetAsync($"api/Autors");

            var content = await response.Content.ReadAsStringAsync();

            var viewModel = JsonConvert.DeserializeObject<List<AutorViewModel>>(content);

            return viewModel;
        }
    }
}
