using CRUD_OperationsInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_OperationsInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            List<Employee> employees = dbContext.Employee.Where(emp => emp.EmployeeId == departmentId).ToList();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            Employee employee = dbContext.Employee.FirstOrDefault(x => x.EmployeeId == id);
            return View(employee);
        }
    }
}