﻿using NHibernate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAppLinq;
using NHibernate.Linq;

namespace TestAppLinq.Controllers
{
    public class HomeController : Controller
    {
        ISession objISession;

        public HomeController()
        {
            objISession = NHibernateSession.OpenSession();
        }

        public ActionResult Index()
        {
            ViewBag.message = new System.IO.DirectoryInfo(HttpContext.Server.MapPath(@"~\AutoGenerated\MappingXML")).ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            List<Employee> employees = EmployeeManagement.GetAllEmployees(objISession);
            var emp = from t in employees
                      where t.EmployeeId == 1
                      select t;
            return View(emp.FirstOrDefault());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Emp()
        {            
            //var employees = objISession.Query<Employee>().ToList();
            //List<Employee> employees = EmployeeManagement.GetAllEmployees(objISession);
            List<Employee> employees = EmployeeManagement.GetResultFromSP(objISession);
            return View(employees);            
        }
    }
}