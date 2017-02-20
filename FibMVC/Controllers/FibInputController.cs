using FibMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FibMVC.Controllers
{
    public class FibInputController : Controller
    {
        // GET: FibInput
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult InputView()
        {
            return View();
        }
        public PartialViewResult DisplayFib(FibModel fib)
        {
            return PartialView();
        }
    }
}