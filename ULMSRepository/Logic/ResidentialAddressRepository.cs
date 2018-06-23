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
    public class ResidentialAddressRepository : IResidentialAddressRepository
    {
        ULMSCustomerContext context;
        public Response EditsResidentialAddress(ResidentialAddress residentialAddress)
        {
            try
            {
                context.ResidentialAddresses.Update(residentialAddress);
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
                    Message = string.Format("{0} \n\n Message: {1}, \n\n StackTrace: {2}",
                    ResponseMessages.FailedToEditEmailAddress, ex.Message, ex.StackTrace)
                };
            }
        }

        public List<ResidentialAddress> GetAllResidentialAddresses()
        {
            return context.ResidentialAddresses.ToList();
        }

        public List<ResidentialAddress> GetResidentialAddressesByCustomerId(int customerId)
        {
            return context.ResidentialAddresses.Where(x => x.CustomerId == customerId).ToList();
        }

        public Response SaveEmailAddress(ResidentialAddress residentialAddress)
        {
            try
            {
                context.ResidentialAddresses.Add(residentialAddress);
                context.SaveChanges();
                return new Response
                {
                    StatusCode = ResponseCodes.Ok,
                    Message = ResponseMessages.GenericSaveSuccessMessage
                };
            }
            catch (Exception ex)
            {
                //Log exception details here.
                return new Response
                {
                    StatusCode = ResponseCodes.InternalServerError,
                    Message = string.Format("{0} \n\n Message: {1}, \n\n StackTrace: {2}",
                    ResponseMessages.FailedToEditEmailAddress, ex.Message, ex.StackTrace)
                };
            }
        }
    }
}
