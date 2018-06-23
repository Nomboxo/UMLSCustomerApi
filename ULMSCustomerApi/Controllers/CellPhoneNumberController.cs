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
    [Route("api/CellPhoneNumber")]
    public class CellPhoneNumberController : Controller
    {
        #region Services.
        public ICellPhoneNumbersService cellPhoneNumbersService;
        #endregion

        public JsonResult SaveCellPhoneNumber(CellPhoneNumberModel cellPhoneNumber)
        {
            var input = CellPhoneNumberMapper.SaveCellPhoneNumber(cellPhoneNumber);
            var response = cellPhoneNumbersService.SaveCellPhoneNumber(input);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult EditCellPhoneNumber(CellPhoneNumberModel cellPhoneNumber)
        {
            var input = CellPhoneNumberMapper.EditCellPhoneNumber(cellPhoneNumber);
            var response = cellPhoneNumbersService.EditCellPhoneNumber(input);
            return new JsonResult(response)
            {
                StatusCode = response.StatusCode
            };
        }

        public JsonResult GetAllCellPhoneNumbers()
        {
            var cellPhoneNumbers = cellPhoneNumbersService.GetAllCellPhoneNumbers();
            var response = CellPhoneNumberMapper.GetAllCellPhoneNumbers(cellPhoneNumbers).ToList();
            
            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };
        }

        public JsonResult GetCustomerCellPhoneNumbers(int customerId)
        {
            var cellPhoneNumbers = cellPhoneNumbersService.GetCustomerCellPhoneNumbers(customerId);
            var response = CellPhoneNumberMapper.GetCustomerCellPhoneNumbers(cellPhoneNumbers).ToList();

            return new JsonResult(response)
            {
                StatusCode = response[0].StatusCode
            };
        }
    }
}