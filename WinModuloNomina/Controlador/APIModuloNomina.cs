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
        // lo de arriva pero con post: la idea es que funcione para agregar, editar y eliminar
        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var respuesta = await _httpClient.PostAsync($"{_baseUrl}/{endpoint}", content);
            respuesta.EnsureSuccessStatusCode();
            var contenido = await respuesta.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(contenido);
        }
        public async Task<T> PutAsync<T>(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var respuesta = await _httpClient.PutAsync($"{_baseUrl}/{endpoint}", content);
            respuesta.EnsureSuccessStatusCode();
            var contenido = await respuesta.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(contenido);
        }
        // eliminar generico <T> tambien 
        public async Task<bool> DeleteAsync(string endpoint)
        {
            var response = await _httpClient.DeleteAsync(_baseUrl + endpoint);
            return response.IsSuccessStatusCode;
        }








    }
}
