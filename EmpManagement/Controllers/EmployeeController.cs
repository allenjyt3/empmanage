using EmpManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpManagement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                EmpDbContext dbContext = new EmpDbContext();
                dbContext.Employees.Add(emp);
                dbContext.SaveChanges();

                return View();
            }
            else
            {
                return View(emp);
            }
        }
       public ActionResult List()
        {

            EmpDbContext dbContext = new EmpDbContext();
            List<Employee> listuser=  dbContext.Employees.ToList();
           // List<Employee> listuser = new List<Employee> { new Employee {email="", },new  };
            //Employee users = new Employee();
            return View(listuser);
        }
        public ActionResult DeleteItem(int id)
        {
            EmpDbContext dbContext = new EmpDbContext();
            Employee emp = dbContext.Employees.Where(c => c.id == id).FirstOrDefault();
            dbContext.Employees.Remove(emp);
            dbContext.SaveChanges();
            return RedirectToAction("List");
        }
        
        public ActionResult EditItem(int id)
        {
            EmpDbContext dbContext = new EmpDbContext();
            Employee emp = dbContext.Employees.Where(c => c.id == id).FirstOrDefault();
            return View(emp);
        }

        [HttpPost]
        public ActionResult EditItem(Employee emp)
        {
            EmpDbContext dbContext = new EmpDbContext();
            Employee emp1 = dbContext.Employees.Where(c => c.id == emp.id).FirstOrDefault();
            // dbContext.Entry(emp1).CurrentValues.SetValues(emp);
            emp1.name = emp.name;
            emp1.email = emp.email;
            emp1.phone = emp.phone;
            dbContext.SaveChanges();
            return RedirectToAction("List");

        }
    }
}