using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TeamderAPI.Models;

namespace Teamder.Services
{
    public class UserService
    {
        private static readonly HttpClient _client = new();
        private const string apiKey = "https://localhost:7007/api/User";
        public async Task AuthorisationUserAsync(string username, string password)
        {
            HttpResponseMessage response = await _client.PostAsync(apiKey + $"/Authorization",
                JsonContent.Create(new User
                {
                    Username = username,
                    Password = password
                }));
            if (response.IsSuccessStatusCode)
            {
                User? user = await response.Content.ReadFromJsonAsync<User>();
                Debug.WriteLine(user.Id + "-" + user.Username);
            }
            else
            {
                Debug.WriteLine("Bad request");
            }
        }
    }
}
