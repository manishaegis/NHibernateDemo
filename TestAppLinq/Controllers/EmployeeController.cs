using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAppLinq.Controllers
{
    public class EmployeeController : Controller
    {
        ISession objISession;
        public EmployeeController()
        {
            objISession = NHibernateSession.OpenSession();
        }
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            List<Employee> employees = EmployeeManagement.GetAllEmployees(objISession);
            return View(employees);            
        }

        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployee(Employee objEmployee)
        {
            return View();
        }
	}
}