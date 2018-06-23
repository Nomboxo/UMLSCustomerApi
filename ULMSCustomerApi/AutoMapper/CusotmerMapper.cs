using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using ULMSCustomerApi.Models;
using ULMSCustomerDomain.Entities;

namespace ULMSCustomerApi.AutoMapper
{
    //ToDo: write logging logic.
    public class CustomerMapper
    {
        #region Initialize.
        public static void InitializeCustomerMapper()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<CellPhoneNumberModel, CellPhoneNumbers>().ReverseMap();
                config.CreateMap<CustomerModel, Customer>().ReverseMap();
            });
        }
        #endregion

        #region Map.
        public static Customer AddNewCustomer(CustomerModel customerModel)
        {
            try
            {
                return Mapper.Map(customerModel, new Customer());
            }
            catch(Exception ex)
            {
                //Log exception details here.
                throw ex;
            }
            
        }
        
        public static Customer EditCustomer(CustomerModel customerModel)
        {
            return Mapper.Map(customerModel, new Customer());
        }

        public static IEnumerable<CustomerModel> GetAllCustomers(List<Customer> customers)
        {
            return Mapper.Map<List<Customer>, List<CustomerModel>>(customers);
        }
        #endregion
    }
}
