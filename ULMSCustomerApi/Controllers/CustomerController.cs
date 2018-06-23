using System.Collections.Generic;
using System.Linq;
using LookUps.Models;
using Microsoft.AspNetCore.Mvc;
using ULMSCustomerApi.AutoMapper;
using ULMSCustomerApi.Models;
using ULMSDomain.Contracts;
using ULMSLookUps.Constants;

namespace ULMSCustomerApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        #region Services.
        public ICustomerService customerService;
        #endregion

        #region Constructors
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        #endregion

        #region Actions.
        [HttpPost("{CustomerModel}")]
        public JsonResult AddNewCustomer([FromBody] CustomerModel customerModel)
        {
            var customer = CustomerMapper.AddNewCustomer(customerModel);
            var response = customerService.AddNewCustomer(customer);

            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }


        [HttpGet("*")]
        public JsonResult GetAllCustomers()
        {
            var customers = customerService.GetAllCustomers();
            var response = CustomerMapper.GetAllCustomers(customers).ToList();

            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };
        }


        [HttpGet("{customerID}")]
        public JsonResult GetCustomerByCustomerID(int customerID)
        {
            var customer = customerService.GetCustomerByCustomerID(customerID);
                        
            return new JsonResult(customer)
            {
                StatusCode = customer.StatusCode
            };
        }

        [HttpPost]
        public JsonResult DeActivateCustomer(int customerID)
        {
            return new JsonResult(new Response());
        }

        [HttpPost]
        public JsonResult EditCustomer(CustomerModel customerModel)
        {
            var customer = CustomerMapper.EditCustomer(customerModel);
            var response = customerService.EditCustomer(customer);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult GetActiveCustomers()
        {
            return new JsonResult(new List<CustomerModel>());
        }
        #endregion
    }
}