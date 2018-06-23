using LookUps.Models;
using System.Collections.Generic;
using ULMSCustomerDomain.Entities;

namespace ULMSDomain.Contracts.Services
{
    public interface ICellPhoneNumbersService
    {
        Response SaveCellPhoneNumber(CellPhoneNumbers cellPhoneNumber);

        Response EditCellPhoneNumber(CellPhoneNumbers cellPhoneNumber);

        List<CellPhoneNumbers> GetAllCellPhoneNumbers();

        List<CellPhoneNumbers> GetCustomerCellPhoneNumbers(int customerId);
    }
}