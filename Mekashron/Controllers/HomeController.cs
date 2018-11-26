using Mekashron.Models;
using Mekashron.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Mekashron.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CustomerViewModel model)
        {
            var proxy = new ICUTechClient();
            var result = proxy.Login(model.Email, model.Password, "");
            var objJavascript = new JavaScriptSerializer();
            var customerModel = objJavascript.Deserialize<CustomerViewModel>(result);
            if (customerModel.EntityId != 0)
            {
                return PartialView("_LoginSuccess", customerModel);
            }
            else
            {
                var errorModel = objJavascript.Deserialize<ErrorViewModel>(result);
                return PartialView("_LoginFail", errorModel);
            }
        }
    }
}