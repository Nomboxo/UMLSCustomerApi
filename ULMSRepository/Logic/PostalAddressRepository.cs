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
    public class PostalAddressRepository : IPostalAddressRepository
    {
        private ULMSCustomerContext context;

        public Response SavePostalAddress(PostalAddress postalAddress)
        {
            try
            {
                context.PostalAddresses.Add(postalAddress);
                context.SaveChanges();
                return new Response
                {
                    StatusCode = ResponseCodes.Ok,
                    Message = ResponseMessages.SuccessfullySavedANewPostalAddress
                };
            }
            catch (Exception ex)
            {
                //Log exception details here.
                return new Response
                {
                    StatusCode = ResponseCodes.InternalServerError,
                    Message = string.Format("{0} \n\n Message: {1}, \n\n StackTrace: {2}",
                    ResponseMessages.FailedToEditPostalAddress, ex.Message, ex.StackTrace)
                };
            }
        }

        public Response EditPostalAddress(PostalAddress postalAddress)
        {
            try
            {
                context.PostalAddresses.Update(postalAddress);
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
                    ResponseMessages.GenericSaveErrorMessage, ex.Message, ex.StackTrace)
                };
            }
        }

        public List<PostalAddress> GetAllPostalAddresses()
        {
            return context.PostalAddresses.ToList();
        }

        public List<PostalAddress> GetPostalAddressesByCustomerId(int customerId)
        {
            return context.PostalAddresses.Where(x => x.CustomerId == customerId).ToList();
        }
    }
}
