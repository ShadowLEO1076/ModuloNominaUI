using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WinModuloNomina.Controlador
{
    
    public class APIModuloNomina
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public APIModuloNomina(string baseUrl)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            _httpClient = new HttpClient();
           
        }
        public async Task<T> GetAsync<T>(string endpoint)
        {
            var respuesta = await _httpClient.GetAsync($"{_baseUrl}/{endpoint}");
            respuesta.EnsureSuccessStatusCode();
            var contenido = await respuesta.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(contenido);

        }

    }
}
