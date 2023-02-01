using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using APITestMateoAvila.Models;

namespace APITestMateoAvila.ViewModels
{
    public class APIClientma
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<UsersMA>> GetUsers()
        {
            var response = await client.GetAsync("https://reqres.in/api/users");
            response.EnsureSuccessStatusCode();
            using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<UsersMA>>(responseStream);
        }
    }
}


