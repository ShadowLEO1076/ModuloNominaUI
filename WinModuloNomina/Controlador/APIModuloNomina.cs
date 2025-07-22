using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Aplicacion.DTO.DTOs;
using Infraestructura.AccesoDatos;
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
        public async Task DeleteAsync(string endpoint)
        {
            var respuesta = await _httpClient.DeleteAsync($"{_baseUrl}/{endpoint}" );

            if (!respuesta.IsSuccessStatusCode)
            {
                string contenido = await respuesta.Content.ReadAsStringAsync();
                throw new Exception($"Error en la petición DELETE: {respuesta.StatusCode} - {contenido}");
            }
        }
        // para obtener el resumen de solicitudes de vacaciones en mi dgvSolicitudes:
        public async Task<List<SolicitudVacacionDTO>> ObtenerResumenSolicitudesVacaciones()
        {
            var endpoint = "SolicitudVacacionesControlador/ObtenerResumenSolicitudes";
            return await GetAsync<List<SolicitudVacacionDTO>>(endpoint);
        }

        









        public async Task<T> CrearEntidad<T>(T entidad,
                                     string endPoint,
                                     string nombreentidad)
        {
            var json = JsonConvert.SerializeObject(entidad);
            var contenido = new StringContent(JsonConvert.SerializeObject(entidad), Encoding.UTF8, "application/json");
            var respuesta = await _httpClient.PostAsync($"{_baseUrl}/{endPoint}", contenido);
           
            if (!respuesta.IsSuccessStatusCode)
            {
                var errorContent = await respuesta.Content.ReadAsStringAsync();
                throw new Exception($"Error al crear {nombreentidad}: {errorContent}");
            }


            var respuestaContenido = await respuesta.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(respuestaContenido);
        }
  

public async Task<T> EliminarAsyn<T>(string endpoint)
        {
            var respuesta = await _httpClient.DeleteAsync($"{_baseUrl}/{endpoint}");
            respuesta.EnsureSuccessStatusCode();
            var contenido = await respuesta.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(contenido);
        }
    }
}
