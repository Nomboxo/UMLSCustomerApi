using LookUps.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ULMSCustomerApi.Models
{
    public class EmailAddressModel : Response
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter CustomerID.")]
        public string CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter email address.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter date that this record was added.")]
        public DateTime AddedOn { get; set; }
        [Required(ErrorMessage = "Please enter username")]
        public string AddedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string MondifiedBy { get; set; }
    }
}