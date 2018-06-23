
using System;
using ULMSCustomerApi.Models;

namespace ULMSCustomerApi.Tests.TestData
{
    public class CustomerBuilder
    {
        public static CustomerModel BuildCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Manelisi",
                Surname = "Nodada",
                ModifiedOn = DateTime.Now,
                AddedOn = DateTime.Now,
                AddedBy = "Test Method",
                MondifiedBy = string.Empty,
                Ocupation = "Software developer"
            };
        }
    }
}
