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
    [Route("api/ResidentialAddress")]
    public class ResidentialAddressController : Controller
    {
        #region Services.
        public IResidentialAddressService ResidentialAddressService;
        #endregion

        public JsonResult SaveResidentialAddress(ResidentialAddressModel ResidentialAddress)
        {
            var input = ResidentialAddressMapper.SaveResidentialAddress(ResidentialAddress);
            var response = ResidentialAddressService.SaveResidentialAddress(input);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult EditResidentialAddress(ResidentialAddressModel ResidentialAddress)
        {
            var input = ResidentialAddressMapper.EditResidentialAddress(ResidentialAddress);
            var response = ResidentialAddressService.EditResidentialAddress(input);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult GetAllResidentialAddresses()
        {
            var ResidentialAddresses = ResidentialAddressService.GetAllResidentialAddresses();
            var response = ResidentialAddressMapper.GetAllResidentialAddresses(ResidentialAddresses).ToList();
            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };

        }

        public JsonResult GetResidentialAddressesByCustomerId(int customerId)
        {
            var ResidentialAddresses = ResidentialAddressService.GetResidentialAddressesByCustomerId(customerId);
            var response = ResidentialAddressMapper.GetCustomerResidentialAddress(ResidentialAddresses).ToList();
            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };
        }
    }
}