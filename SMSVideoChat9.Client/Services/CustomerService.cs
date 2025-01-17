 
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SharedLibrary.Models;

    namespace SMSVideoChat9.Client.Services
    {
        public class CustomerService : ICustomerService
        {
            private readonly HttpClient _httpClient;

            public CustomerService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task<IEnumerable<Customer>> GetCustomerAsync()
            {
                return await _httpClient.GetFromJsonAsync<IEnumerable<Customer>>("api/Customers");
            }

            public async Task<Customer> GetCustomerAsync(int id)
            {
                return await _httpClient.GetFromJsonAsync<Customer>($"api/Customers/{id}");
            }

            public async Task CreateCustomerAsync(Customer customer)
            {
                await _httpClient.PostAsJsonAsync("api/Customers", customer);
            }

            public async Task UpdateCustomerAsync(int id, Customer customer)
            {
                await _httpClient.PutAsJsonAsync($"api/Customers/{id}", customer);
            }

            public async Task DeleteCustomerAsync(int id)
            {
                await _httpClient.DeleteAsync($"api/Customers/{id}");
            }
        }
    }
