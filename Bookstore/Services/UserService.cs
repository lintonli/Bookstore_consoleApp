using Bookstore.Services.IServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Services
{
    public class UserService : IUser
    {
        private readonly HttpClient _httpClient;
        private readonly string URL = "http://localhost:3000/users";

        public UserService()
        {
            _httpClient = new HttpClient();
        }
        public Task<string> AddUser(AddUser newuser)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetRegisterAsync()
        {
            var response = await _httpClient.GetAsync(URL);
            var content = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<User>>(content);
            if(response.IsSuccessStatusCode && users != null) {
                return users;
            }
            return  new List<User> { new User() };

        }

        public Task<User> GetRegisterByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateUser(int id, AddUser updatedUser)
        {
            throw new NotImplementedException();
        }
    }
}
