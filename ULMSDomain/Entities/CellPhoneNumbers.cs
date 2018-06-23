using System;
using System.ComponentModel.DataAnnotations;

namespace ULMSCustomerDomain.Entities
{
    public class CellPhoneNumbers
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Number { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string MondifiedBy { get; set; }
    }
}