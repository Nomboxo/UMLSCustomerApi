using AutoMapper;
using System.Collections.Generic;
using ULMSCustomerApi.Models;
using ULMSCustomerDomain.Entities;

namespace ULMSCustomerApi.AutoMapper
{
    public class ResidentialAddressMapper
    {
        public static ResidentialAddress SaveResidentialAddress(ResidentialAddressModel residentialAddressModel)
        {
            return Mapper.Map(residentialAddressModel, new ResidentialAddress());
        }

        public static ResidentialAddress EditResidentialAddress(ResidentialAddressModel residentialAddressModel)
        {
            return Mapper.Map(residentialAddressModel, new ResidentialAddress());
        }

        public static IEnumerable<ResidentialAddressModel> GetAllResidentialAddresses(List<ResidentialAddress> residentialAddress)
        {
            return Mapper.Map<List<ResidentialAddress>, List<ResidentialAddressModel>>(residentialAddress);
        }

        public static IEnumerable<ResidentialAddressModel> GetCustomerResidentialAddress(List<ResidentialAddress> residentialAddress)
        {
            return Mapper.Map<List<ResidentialAddress>, List<ResidentialAddressModel>>(residentialAddress);
        }
    }
}
