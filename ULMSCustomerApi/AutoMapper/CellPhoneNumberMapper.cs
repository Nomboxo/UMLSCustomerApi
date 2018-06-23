using AutoMapper;
using System.Collections.Generic;
using ULMSCustomerApi.Models;
using ULMSCustomerDomain.Entities;

namespace ULMSCustomerApi.AutoMapper
{
    public class CellPhoneNumberMapper
    {
        public static CellPhoneNumbers SaveCellPhoneNumber(CellPhoneNumberModel cellPhoneNumber)
        {
            return Mapper.Map(cellPhoneNumber, new CellPhoneNumbers());
        }

        public static CellPhoneNumbers EditCellPhoneNumber(CellPhoneNumberModel cellPhoneNumber)
        {
            return Mapper.Map(cellPhoneNumber, new CellPhoneNumbers());
        }

        public static IEnumerable<CellPhoneNumberModel> GetAllCellPhoneNumbers(List<CellPhoneNumbers> cellPhoneNubmers)
        {
            return Mapper.Map<List<CellPhoneNumbers>, List<CellPhoneNumberModel>>(cellPhoneNubmers);
        }
        
        public static IEnumerable<CellPhoneNumberModel> GetCustomerCellPhoneNumbers(List<CellPhoneNumbers> cellPhoneNubmers)
        {
            return Mapper.Map<List<CellPhoneNumbers>, List<CellPhoneNumberModel>>(cellPhoneNubmers);
        }
    }
}
