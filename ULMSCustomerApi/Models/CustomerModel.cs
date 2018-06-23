using LookUps.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static LookUps.Enums.CustomerTypes;

namespace ULMSCustomerApi.Models
{
    public class CustomerModel: Response
    {
        [Required(ErrorMessage ="Please enter ID")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter First name.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter Surname.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter Occupation.")]
        public string Ocupation { get; set; }
        [Required(ErrorMessage = "Please enter AddedOn date.")]
        public DateTime AddedOn { get; set; }
        [Required(ErrorMessage = "Please enter username of person who's adding this record.")]
        public string AddedBy { get; set; }
        [Required(ErrorMessage = "Please enter the date that this record was edited.")]
        public DateTime ModifiedOn { get; set; }
        [Required(ErrorMessage = "Please enter username of the person editing this record")]
        public string MondifiedBy { get; set; }

        public CusotmerTypes CustomerType { get; set; }
        public PostalAddressModel PostalAddress { get; set; }
        public List<EmailAddressModel> EmailAddresses { get; set; }
        public List<CellPhoneNumberModel> CellPhoneNumbers { get; set; }
        public ResidentialAddressModel ResidentialAddress { get; set; }
    }
}
