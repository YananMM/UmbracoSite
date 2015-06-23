using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace SimpleUmbraco.Model
{
    public class ContactUsRenderModel : RenderModel
    {
        public ContactUsRenderModel() : this(new UmbracoHelper(UmbracoContext.Current).TypedContent(UmbracoContext.Current.PageId)) { }
        public ContactUsRenderModel(IPublishedContent content, CultureInfo culture) : base(content, culture) { }
        public ContactUsRenderModel(IPublishedContent content) : base(content) { }
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        [Required, Display(Name = "Enter your user name")]
        public string Username { get; set; }
        [Required, Display(Name = "Enter your phone number"), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
 
    }

    public class Contact
    {
        public Contact(string username, string phonenumber)
        {
            this.Username = username;
            this.PhoneNumber = phonenumber;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        [Required, Display(Name = "Enter your user name")]
        public string Username { get; set; }
        [Required, Display(Name = "Enter your phone number"), DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }

    public class ContactFormContext : DbContext
    {
        public ContactFormContext() : base("umbracoDbDSN") { }
        public DbSet<Contact> Contacts { get; set; } 
    }
}