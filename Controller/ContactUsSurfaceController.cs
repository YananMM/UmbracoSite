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
        [System.Web.Http.ActionName("ContactUsForm")]
        public ActionResult ContactUsForm(ContactUsModel model)
        {
            if (!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }
            else
            {
                return CurrentUmbracoPage();

            }
        }
    }
}