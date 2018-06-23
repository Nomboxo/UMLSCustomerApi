using LookUps.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static LookUps.Enums.CustomerTypes;

namespace ULMSCustomerDomain.Entities
{
    public class Customer : Response
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Ocupation { get; set; }
        public DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string MondifiedBy { get; set; }
        public CusotmerTypes CustomerType { get; set; }
        public PostalAddress PostalAddress { get; set; }
        public List<EmailAddress> EmailAddresses { get; set; }
        public List<CellPhoneNumbers> CellPhoneNumbers { get; set; }
        public ResidentialAddress ResidentialAddress { get; set; }
    }
}