using System.Collections.Generic;
using LookUps.Models;
using ULMSCustomerDomain.Entities;
using ULMSDomain.Contracts;
using ULMSLookUps.Constants;

namespace ULMSDomain.Services
{
    public class CustomerService : ICustomerService
    {
        ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Response AddNewCustomer(Customer customer)
        {
            return customerRepository.AddNewCustomer(customer);
        }

        public Customer EditCustomer(Customer customer)
        {
            return customerRepository.EditCustomer(customer);
        }
        
        public List<Customer> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }

        public Customer GetCustomerByCustomerID(int customerId)
        {
            return customerRepository.GetCustomerByCustomerID(customerId);
        }
    }
}
