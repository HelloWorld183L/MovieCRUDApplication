using Microsoft.AspNet.Identity;
using MovieCRUD.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieCRUD.Controllers
{
    public class ControllerExtensions : Controller
    {
        public static ControllerExtensions Instance { get; } = new ControllerExtensions();

        public void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
    }
}