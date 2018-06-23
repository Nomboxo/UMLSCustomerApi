using System;

namespace ULMSCustomerDomain.Entities
{
    public class ResidentialAddress
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string PostalCode { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string MondifiedBy { get; set; }
        public Customer Customer { get; set; }
    }
}