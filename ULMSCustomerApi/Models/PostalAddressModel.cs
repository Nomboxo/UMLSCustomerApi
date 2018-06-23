using LookUps.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ULMSCustomerApi.Models
{
    public class PostalAddressModel: Response
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please provide CustomerId")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please provide City name.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please provide Province.")]
        public string Province { get; set; }
        [Required(ErrorMessage = "Please provide Line1")]
        public string Line1 { get; set; }
        [Required(ErrorMessage = "Please provide Line2")]
        public string Line2 { get; set; }
        [Required(ErrorMessage = "Please provide Line3")]
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please provide Postal Code.")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Please provide AddedOn date.")]
        public DateTime AddedOn { get; set; }
        [Required(ErrorMessage = "Please provide AddedBy date.")]
        public string AddedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string MondifiedBy { get; set; }
    }
}
