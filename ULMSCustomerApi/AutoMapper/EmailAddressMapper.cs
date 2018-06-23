using AutoMapper;
using System.Collections.Generic;
using ULMSCustomerApi.Models;
using ULMSCustomerDomain.Entities;

namespace ULMSCustomerApi.AutoMapper
{
    public class EmailAddressMapper
    {
        public static EmailAddress SaveEmailAddress(EmailAddressModel emailAddressModel)
        {
            return Mapper.Map(emailAddressModel, new EmailAddress());
        }

        public static EmailAddress EditEmailAddress(EmailAddressModel emailAddressModel)
        {
            return Mapper.Map(emailAddressModel, new EmailAddress());
        }

        public static IEnumerable<EmailAddressModel> GetAllEmailAddresses(List<EmailAddress> emailAddress)
        {
            return Mapper.Map<List<EmailAddress>, List<EmailAddressModel>>(emailAddress);
        }

        public static IEnumerable<EmailAddressModel> GetCustomerEmailAddresses(List<EmailAddress> emailAddress)
        {
            return Mapper.Map<List<EmailAddress>, List<EmailAddressModel>>(emailAddress);
        }
    }
}
