using System.Collections.Generic;
using LookUps.Models;
using ULMSCustomerDomain.Entities;
using ULMSDomain.Contracts.Repository;
using ULMSDomain.Contracts.Services;

namespace ULMSDomain.Services
{
    public class PostalAddressService : IPostalAddressService
    {
        IPostalAddressRepository postalAddressRepository;

        public PostalAddressService(IPostalAddressRepository postalAddressRepository)
        {
            this.postalAddressRepository = postalAddressRepository;
        }

        public Response SavePostalAddress(PostalAddress postalAddress)
        {
            return postalAddressRepository.SavePostalAddress(postalAddress);
        }

        public Response EditPostalAddress(PostalAddress postalAddress)
        {
            return postalAddressRepository.EditPostalAddress(postalAddress);
        }

        public List<PostalAddress> GetAllPostalAddresses()
        {
            return postalAddressRepository.GetAllPostalAddresses();
        }

        public List<PostalAddress> GetPostalAddressesByCustomerId(int customerId)
        {
            return postalAddressRepository.GetPostalAddressesByCustomerId(customerId);
        }
    }
}
