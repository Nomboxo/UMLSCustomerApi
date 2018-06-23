using System.Collections.Generic;
using LookUps.Models;
using ULMSCustomerDomain.Entities;
using ULMSDomain.Contracts.Repository;
using ULMSDomain.Contracts.Services;

namespace ULMSDomain.Services
{
    public class ResidentialAddressService : IResidentialAddressService
    {
        IResidentialAddressRepository residentialAddressRepository;

        public ResidentialAddressService(IResidentialAddressRepository residentialAddressRepository)
        {
            this.residentialAddressRepository = residentialAddressRepository;
        }

        public Response EditResidentialAddress(ResidentialAddress residentialAddress)
        {
            return residentialAddressRepository.EditsResidentialAddress(residentialAddress);
        }

        public List<ResidentialAddress> GetAllResidentialAddresses()
        {
            return residentialAddressRepository.GetAllResidentialAddresses();
        }

        public List<ResidentialAddress> GetResidentialAddressesByCustomerId(int customerId)
        {
            return residentialAddressRepository.GetResidentialAddressesByCustomerId(customerId);
        }

        public Response SaveResidentialAddress(ResidentialAddress residentialAddress)
        {
            return residentialAddressRepository.SaveEmailAddress(residentialAddress);
        }
    }
}
