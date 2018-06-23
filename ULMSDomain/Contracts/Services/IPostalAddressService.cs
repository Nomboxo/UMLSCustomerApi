using LookUps.Models;
using System.Collections.Generic;
using ULMSCustomerDomain.Entities;

namespace ULMSDomain.Contracts.Services
{
    public interface IPostalAddressService
    {
        Response SavePostalAddress(PostalAddress postalAddress);

        Response EditPostalAddress(PostalAddress postalAddress);

        List<PostalAddress> GetAllPostalAddresses();

        List<PostalAddress> GetPostalAddressesByCustomerId(int customerId);
    }
}
