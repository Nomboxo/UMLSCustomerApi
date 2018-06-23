using System;
using System.Collections.Generic;
using System.Linq;
using LookUps.Models;
using ULMSCustomerDomain.Entities;
using ULMSDomain.Contracts.Repository;
using ULMSLookUps.Constants;
using ULMSRepository.Context;

namespace ULMSRepository.Logic
{
    public class EmailAddressRepository : IEmailAddressRepository
    {
        private ULMSCustomerContext context;

        public Response SaveEmailAddress(EmailAddress emailAddress)
        {
            try
            {
                context.EmailAddresses.Add(emailAddress);
                context.SaveChanges();
                return new Response
                {
                    StatusCode = ResponseCodes.Ok,
                    Message = ResponseMessages.SuccessfullySavedANewEmailAddress
                };
            }
            catch (Exception ex)
            {
                //Log exception details here.
                return new Response
                {
                    StatusCode = ResponseCodes.InternalServerError,
                    Message = ex.ToString()
                };
            }
        }

        public Response EditEmailAddress(EmailAddress emailAddress)
        {
            try
            {
                context.EmailAddresses.Update(emailAddress);
                context.SaveChanges();
                return new Response
                {
                    StatusCode = ResponseCodes.Ok,
                    Message = ResponseMessages.SuccessfullySavedANewEmailAddress
                };
            }
            catch (Exception ex)
            {
                //Log exception details here.
                return new Response
                {
                    StatusCode = ResponseCodes.InternalServerError,
                    Message = ex.ToString()
                };
            }
        }

        public List<EmailAddress> GetAllEmailAddresses()
        {
            return context.EmailAddresses.ToList();
        }

        public List<EmailAddress> GetEmailAddressesByCustomerId(int customerId)
        {
            return context.EmailAddresses.Where(x => x.CustomerId == customerId).ToList();
        }
    }
}
