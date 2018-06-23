using LookUps.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ULMSCustomerApi.Models
{
    public class CellPhoneNumberModel: Response
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide CustomerId")]
        public string CustomerId { get; set; }
        [Required(ErrorMessage = "Please provide Phone number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please provide AddedOn date.")]
        public DateTime AddedOn { get; set; }
        [Required(ErrorMessage = "Please provide AddedBy username")]
        public string AddedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string MondifiedBy { get; set; }
    }
}
