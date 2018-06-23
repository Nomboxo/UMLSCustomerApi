using LookUps.Models;
using System.Collections.Generic;
using ULMSCustomerDomain.Entities;

namespace ULMSDomain.Contracts.Services
{
    public interface IResidentialAddressService
    {
        Response SaveResidentialAddress(ResidentialAddress residentialAddress);

        Response EditResidentialAddress(ResidentialAddress residentialAddress);

        List<ResidentialAddress> GetAllResidentialAddresses();

        List<ResidentialAddress> GetResidentialAddressesByCustomerId(int customerId);
    }
}
