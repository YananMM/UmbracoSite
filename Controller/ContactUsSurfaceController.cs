using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleUmbraco.Model;

namespace SimpleUmbraco.Controller
{
    public class ContactUsSurfaceController : Umbraco.Web.Mvc.SurfaceController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.ActionName("HandleContactSubmit")]
        public ActionResult HandleContactSubmit(ContactUsRenderModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }
            else
            {
                using (var db = new ContactFormContext())
                {
                    db.Contacts.Add(new Contact(model.Username, model.PhoneNumber));
                    db.SaveChanges();
                    TempData["FormSuccess"] = true;
                    TempData["Name"] = model.Username;
                }
                return CurrentUmbracoPage();

            }
        }
    }
}