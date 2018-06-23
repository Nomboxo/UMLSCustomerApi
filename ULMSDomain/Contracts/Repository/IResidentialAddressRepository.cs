using LookUps.Models;
using System.Collections.Generic;
using ULMSCustomerDomain.Entities;

namespace ULMSDomain.Contracts.Repository
{
    public interface IResidentialAddressRepository
    {
        Response SaveEmailAddress(ResidentialAddress residentialAddress);

        Response EditsResidentialAddress(ResidentialAddress residentialAddress);

        List<ResidentialAddress> GetAllResidentialAddresses();

        List<ResidentialAddress> GetResidentialAddressesByCustomerId(int customerId);
    }
}
