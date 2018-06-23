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
    public class CellPhoneNumbersRepository : ICellPhoneNumbersRepository
    {
        private ULMSCustomerContext context;

        public Response EditCellPhoneNumber(CellPhoneNumbers cellPhoneNumber)
        {
            try
            {
                context.CellPhoneNumbers.Update(cellPhoneNumber);
                context.SaveChanges();
                return new Response
                {
                    StatusCode = ResponseCodes.Ok,
                    Message = ResponseMessages.SaveSuccessfully
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

        public List<CellPhoneNumbers> GetAllCellPhoneNumbers()
        {
            return context.CellPhoneNumbers.ToList();
        }

        public List<CellPhoneNumbers> GetCustomerCellPhoneNumbers(int customerId)
        {
            return context.CellPhoneNumbers.Where(x => x.CustomerId == customerId).ToList();
        }

        public Response SaveCellPhoneNumber(CellPhoneNumbers cellPhoneNumber)
        {
            try
            {
                context.CellPhoneNumbers.Add(cellPhoneNumber);
                context.SaveChanges();
                return new Response
                {
                    StatusCode = ResponseCodes.Ok,
                    Message = ResponseMessages.SaveSuccessfully
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
    }
}