using SharedLibrary.Models;
using SMSVideoChat9.Client.Services;

namespace SMSVideoChat9.Client.Services
{
    public interface ICustomerService
    {
            Task<IEnumerable<Customer>> GetCustomerAsync();
            Task<Customer> GetCustomerAsync(int id);
            Task CreateCustomerAsync(Customer friend);
            Task UpdateCustomerAsync(int id, Customer friend);
            Task DeleteCustomerAsync(int id);
        }
 }

