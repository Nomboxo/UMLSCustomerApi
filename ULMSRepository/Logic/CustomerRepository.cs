using System;
using System.Collections.Generic;
using LookUps.Models;
using ULMSCustomerDomain.Entities;
using ULMSDomain.Contracts;
using ULMSLookUps.Constants;
using ULMSRepository.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ULMSRepository.Logic
{
    public class CustomerRepository : ICustomerRepository
    {
        private ULMSCustomerContext customerContext;

        public CustomerRepository()
        {
            customerContext = new ULMSCustomerContext();
            //customerContext.provid
        }

        public Response AddNewCustomer(Customer customer)
        {
            try
            {
                customerContext.Customers.Add(customer);
                customerContext.SaveChanges();
                return new Response
                {
                    StatusCode = ResponseCodes.Ok,
                    Message = ResponseMessages.SuccessfullySavedNewCustomer
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
        
        public Customer EditCustomer(Customer customer)
        {
            try
            {
                //Persist to the database.
                customerContext.Update(customer);
                customerContext.SaveChanges();

                //Build response.
                customer.StatusCode = ResponseCodes.Ok;
                customer.Message = ResponseMessages.SuccessfullySavedCustomerDetails;
                return customer;
            }
            catch (Exception ex)
            {
                //Log exception details here.
                return new Customer
                {
                    StatusCode = ResponseCodes.InternalServerError,
                    Message = string.Format("{0} \n\n Message: {1}, \n\n StackTrace: {2}",
                    ResponseMessages.FailedToSaveCustomerDetails, ex.Message, ex.StackTrace)
                };
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers;
            try
            {
                customers = customerContext.Customers
                   .Include(p => p.PostalAddress)
                   .Include(r => r.ResidentialAddress)
                   .Include(c => c.CellPhoneNumbers)
                   .Include(e => e.EmailAddresses)
                   .ToList();

                if (customers != null && customers.Any())
                {
                    customers[0].StatusCode = ResponseCodes.Ok;
                    customers[0].Message = ResponseMessages.Success;
                }
                else
                {
                    var notFoundResponse = new List<Customer>();
                    notFoundResponse.Add(new Customer { Message = ResponseMessages.NoRecordFound, StatusCode = ResponseCodes.Ok });
                    return notFoundResponse;
                }

                return customers;
            }
            catch (Exception ex)
            {
                //TODO: Log exception details here.
                customers = new List<Customer>
                    { new Customer
                     {
                        Message = ex.ToString(),
                        StatusCode = ResponseCodes.InternalServerError
                    }};

                return customers;
            }
        }

        public Customer GetCustomerByCustomerID(int customerId)
        {
            Customer customer;
            try
            {
                customer = customerContext.Customers
                   .Include(p => p.PostalAddress)
                   .Include(r => r.ResidentialAddress)
                   .Include(c => c.CellPhoneNumbers)
                   .Include(e => e.EmailAddresses)
                   .FirstOrDefault(x => x.Id == customerId);

                if (customer != null)
                {
                    customer.StatusCode = ResponseCodes.Ok;
                    customer.Message = ResponseMessages.Success;
                }
                else
                {
                    customer = new Customer
                    {
                        StatusCode = ResponseCodes.Ok,
                        Message = ResponseMessages.NoRecordFound,
                    };
                }

                return customer;
            }
            catch (Exception ex)
            {
                //TODO: Log exception details here.
                customer = new Customer
                {
                    StatusCode = ResponseCodes.InternalServerError,
                    Message = ex.ToString(),
                };

                return customer;
            }
        }
    }
}
