using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ULMSCustomerApi.AutoMapper;
using ULMSCustomerApi.Models;
using ULMSDomain.Contracts;

namespace ULMSCustomerApi.Controllers
{
    [Produces("application/json")]
    [Route("api/EmailAddress")]
    public class EmailAddressController : Controller
    {
        #region Services.
        public IEmailAddressService EmailAddressService;
        #endregion

        public JsonResult SaveEmailAddress(EmailAddressModel EmailAddress)
        {
            var input = EmailAddressMapper.SaveEmailAddress(EmailAddress);
            var response = EmailAddressService.SaveEmailAddress(input);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult EditEmailAddress(EmailAddressModel EmailAddress)
        {
            var input = EmailAddressMapper.EditEmailAddress(EmailAddress);
            var response = EmailAddressService.EditEmailAddress(input);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult GetAllEmailAddresses()
        {
            var EmailAddresses = EmailAddressService.GetAllEmailAddresses();
            var response = EmailAddressMapper.GetAllEmailAddresses(EmailAddresses).ToList();
            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };

        }

        public JsonResult GetEmailAddressesByCustomerId(int customerId)
        {
            var EmailAddresses = EmailAddressService.GetEmailAddressesByCustomerId(customerId);
            var response = EmailAddressMapper.GetCustomerEmailAddresses(EmailAddresses).ToList();
            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };
        }
    }
}