using System.Collections.Generic;
using LookUps.Models;
using ULMSCustomerDomain.Entities;
using ULMSDomain.Contracts;
using ULMSDomain.Contracts.Repository;

namespace ULMSDomain.Services
{
    public class EmailAddressService : IEmailAddressService
    {
        IEmailAddressRepository emailAddressRepository;

        public EmailAddressService(IEmailAddressRepository emailAddressRepository)
        {
            this.emailAddressRepository = emailAddressRepository;
        }

        public Response EditEmailAddress(EmailAddress emailAddress)
        {
            return emailAddressRepository.EditEmailAddress(emailAddress);
        }

        public List<EmailAddress> GetAllEmailAddresses()
        {
            return emailAddressRepository.GetAllEmailAddresses();
        }

        public List<EmailAddress> GetEmailAddressesByCustomerId(int customerId)
        {
            return emailAddressRepository.GetEmailAddressesByCustomerId(customerId);
        }

        public Response SaveEmailAddress(EmailAddress emailAddress)
        {
            return emailAddressRepository.SaveEmailAddress(emailAddress);
        }
    }
}
