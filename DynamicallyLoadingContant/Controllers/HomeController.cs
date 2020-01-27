using DynamicallyLoadingContant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicallyLoadingContant.Controllers
{
    public class HomeController : Controller
    {
        MVCTutorialEntities db = new MVCTutorialEntities();
        public ActionResult Index()
        {
            return View(db.EmployeeInfoes.ToList());
        }

        public ActionResult EmployeeInfo(int id)
        {
            List<EmployeeInfo> EmpInfo = db.EmployeeInfoes.Where(x => x.EmployeeId == id).ToList();
            return View(EmpInfo);
        }
    }
}