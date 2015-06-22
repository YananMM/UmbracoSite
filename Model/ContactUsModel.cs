using System.ComponentModel.DataAnnotations;

namespace SimpleUmbraco.Model
{
    public class ContactUsModel
    {
        [Required, Display(Name = "Enter your user name")]
        public string Username { get; set; }
        [Required, Display(Name = "Enter your phone number"), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}