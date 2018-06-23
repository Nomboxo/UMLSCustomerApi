using System;
using System.ComponentModel.DataAnnotations;

namespace ULMSCustomerDomain.Entities
{
    public class EmailAddress
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Address { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string MondifiedBy { get; set; }
    }
}