using LookUps.Models;
using System.Collections.Generic;
using ULMSCustomerDomain.Entities;

namespace ULMSDomain.Contracts.Repository
{
    public interface IEmailAddressRepository
    {
        Response SaveEmailAddress(EmailAddress emailAddress);

        Response EditEmailAddress(EmailAddress emailAddress);

        List<EmailAddress> GetAllEmailAddresses();

        List<EmailAddress> GetEmailAddressesByCustomerId(int customerId);
    }
}
