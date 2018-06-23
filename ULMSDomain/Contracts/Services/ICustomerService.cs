using LookUps.Models;
using System.Collections.Generic;
using ULMSCustomerDomain.Entities;

namespace ULMSDomain.Contracts
{
    public interface ICustomerService
    {
        Response AddNewCustomer(Customer customer);

        Customer GetCustomerByCustomerID(int customerId);
        
        Customer EditCustomer(Customer customer);

        List<Customer> GetAllCustomers();
    }
}
