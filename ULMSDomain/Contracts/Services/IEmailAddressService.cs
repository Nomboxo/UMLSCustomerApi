using LookUps.Models;
using System.Collections.Generic;
using ULMSCustomerDomain.Entities;

namespace ULMSDomain.Contracts
{
    public interface IEmailAddressService
    {
        Response SaveEmailAddress(EmailAddress emailAddress);
        List<EmailAddress> GetAllEmailAddresses();
        List<EmailAddress> GetEmailAddressesByCustomerId(int customerId);
        Response EditEmailAddress(EmailAddress emailAddress);
    }
}