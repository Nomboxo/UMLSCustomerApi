using System.Collections.Generic;
using LookUps.Models;
using ULMSCustomerDomain.Entities;
using ULMSDomain.Contracts.Repository;
using ULMSDomain.Contracts.Services;

namespace ULMSDomain.Services
{
    public class CellPhoneNumbersService : ICellPhoneNumbersService
    {

        ICellPhoneNumbersRepository cellPhoneNumberRepository;

        public CellPhoneNumbersService(ICellPhoneNumbersRepository cellPhoneNumberRepository)
        {
            this.cellPhoneNumberRepository = cellPhoneNumberRepository;
        }

        public Response EditCellPhoneNumber(CellPhoneNumbers cellPhoneNumber)
        {
            return cellPhoneNumberRepository.EditCellPhoneNumber(cellPhoneNumber);
        }

        public List<CellPhoneNumbers> GetAllCellPhoneNumbers()
        {
            return cellPhoneNumberRepository.GetAllCellPhoneNumbers();
        }

        public List<CellPhoneNumbers> GetCustomerCellPhoneNumbers(int customerId)
        {
            return cellPhoneNumberRepository.GetCustomerCellPhoneNumbers(customerId);
        }

        public Response SaveCellPhoneNumber(CellPhoneNumbers cellPhoneNumber)
        {
            return cellPhoneNumberRepository.SaveCellPhoneNumber(cellPhoneNumber);
        }
    }
}
