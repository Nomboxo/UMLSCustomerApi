using AutoMapper;
using System.Collections.Generic;
using ULMSCustomerApi.Models;
using ULMSCustomerDomain.Entities;

namespace ULMSCustomerApi.AutoMapper
{
    public class PostalAddressMapper
    {
        public static PostalAddress SavePostalAddress(PostalAddressModel PostalAddressModel)
        {
            return Mapper.Map(PostalAddressModel, new PostalAddress());
        }

        public static PostalAddress EditPostalAddress(PostalAddressModel PostalAddressModel)
        {
            return Mapper.Map(PostalAddressModel, new PostalAddress());
        }

        public static IEnumerable<PostalAddressModel> GetAllPostalAddresses(List<PostalAddress> postalAddress)
        {
            return Mapper.Map<List<PostalAddress>, List<PostalAddressModel>>(postalAddress);
        }

        public static IEnumerable<PostalAddressModel> GetCustomerPostalAddress(List<PostalAddress> postalAddress)
        {
            return Mapper.Map<List<PostalAddress>, List<PostalAddressModel>>(postalAddress);
        }
    }
}
