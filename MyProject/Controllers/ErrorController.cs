using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeErros(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.StatusCode = "404:Not Found";
                    ViewData["ErrorMessage"] = "Sorry, resource you are requested could not be found";
                    break;
                case 400:
                    ViewBag.StatusCode = "400:Bad Request";
                    ViewData["ErrorMessage"] = "Sorry, the requested could not be understoond by the server or Invalid Url";
                    break;
                case 500:
                    ViewBag.StatusCode = "500: Internal Server Error";
                    ViewData["ErrorMessage"] = "Sorry, Internal Server Error. Please try after sometime or refresh your page again.";
                    break;
            }
            return View("CommonError");
        }
    }
}
