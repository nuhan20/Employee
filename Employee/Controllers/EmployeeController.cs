using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.Models;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tamplated()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Tamplated(EmployeeModel emp)
        {
            return View();
        }

        public ActionResult ExtensionMethod()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ExtensionMethod(EmployeeModel emp)
        {
            return View();
        }

        public ActionResult StronglyTypedMethod()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StronglyTypedMethod(EmployeeModel emp)
        {
            return View();
        }
    }
}