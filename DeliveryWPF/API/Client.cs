using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DeliveryWPF.DTO;
using Newtonsoft.Json;

namespace DeliveryWPF.API
{
    public class Client
    {
        HttpClient httpClient = new HttpClient();
        public Client()
        {
            httpClient.BaseAddress = new Uri(@"https://localhost:7245/");
        }
        public async Task<UserDTO> UserLogin(string login, string password)
        {
            var loginUser = new LoginUser
            {
                Login = login,
                Password = password
            };
            var jsonContent = JsonConvert.SerializeObject(loginUser);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await httpClient.PostAsync("User/UserLogin", httpContent);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Неправильный логин или пароль");
            }
            var answerUser = JsonConvert.DeserializeObject<UserDTO>(await response.Content.ReadAsStringAsync());
            return answerUser;
        }
        
        static Client instance = new();
        public static Client Instance
        {
            get
            {
                if (instance == null)
                    instance = new Client();
                return instance;
            }
        }
    }
}
