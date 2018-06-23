using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ULMSCustomerApi.AutoMapper;
using ULMSCustomerApi.Models;
using ULMSDomain.Contracts.Services;

namespace ULMSCustomerApi.Controllers
{
    [Produces("application/json")]
    [Route("api/PostalAddress")]
    public class PostalAddressController : Controller
    {
        #region Services.
        public IPostalAddressService postalAddressService;
        #endregion

        public JsonResult SavePostalAddress(PostalAddressModel postalAddress)
        {
            var input = PostalAddressMapper.SavePostalAddress(postalAddress);
            var response = postalAddressService.SavePostalAddress(input);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult EditPostalAddress(PostalAddressModel postalAddress)
        {
            var input = PostalAddressMapper.EditPostalAddress(postalAddress);
            var response = postalAddressService.EditPostalAddress(input);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult GetAllPostalAddresses()
        {
            var postalAddresses = postalAddressService.GetAllPostalAddresses();
            var response = PostalAddressMapper.GetAllPostalAddresses(postalAddresses).ToList();
            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };

        }

        public JsonResult GetPostalAddressesByCustomerId(int customerId)
        {
            var postalAddresses = postalAddressService.GetPostalAddressesByCustomerId(customerId);
            var response = PostalAddressMapper.GetCustomerPostalAddress(postalAddresses).ToList();
            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };
        }

    }
}