using CRUD_OperationsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_OperationsInMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            List<Department> listDepartments = dbContext.Department.ToList();
            return View(listDepartments);
        }
    }
}