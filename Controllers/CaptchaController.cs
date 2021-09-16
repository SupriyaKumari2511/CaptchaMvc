using CaptchaMvc.HtmlHelpers;
using MVCCaptcha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCaptcha.Controllers
{
    public class CaptchaController : Controller
    {
        // GET: Captcha
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(RegisterationModel objRegisterationModel)
        {
            if (!this.IsCaptchaValid(""))
            {
                ViewBag.ErrorMessage = "captcha is not valid";
                return View("Index", objRegisterationModel);
            }
            return Content("captcha is valid");
        }
    }
}