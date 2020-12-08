using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCDemo2.Models;
using MVCDemo2.Models.Employees;
using MVCDemo2.ViewModel;

namespace MVCDemo2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _employeeContext;
        public EmployeeController(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        //public IActionResult Index()
        //{
        //    List<Employee> employees = _employeeContext.Employees.ToList();

        //    return View(employees);
        //}
        //public IActionResult Details(int id)
        //{
        //    Employee employee= _employeeContext.Employees.Single(emp => emp.EmployeeId == id);
        //    var viewModel = new EmployeeViewModel
        //    {
        //        Employee=employee
        //    };
        //    return View(employee);
        //}

        public IActionResult Index()
        {
            var employees = _employeeContext.Employees;
            ViewBag.Emp = new SelectList(employees.ToList(), "EmployeeId", "Name");
            return View(employees);
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult Index(IFormCollection form, int employees, ddValueExample ddValueExample )
        {

            var employees2 = _employeeContext.Employees;
            ViewBag.Emp = new SelectList(employees2.ToList(), "EmployeeId", "Name", employees);
            var employees1 = employees2.Where(x => x.EmployeeId == employees).ToList();
            return View("Index", employees1);
        }

        //public IActionResult Index()
        //{ 
        //    var employees = new List<Employee>()
        //    {
        //        new Employee{Name="Monali",Age=25},
        //        new Employee{Name="abx",Age=28}
        //    };
        //    ViewBag.Emp = employees;
        //    return View();
        //}



        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeContext.Add(employee);
                await _employeeContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getEmployeeDetail = await _employeeContext.Employees.FindAsync(id);

            return View(getEmployeeDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeContext.Update(employee);
                await _employeeContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getEmployeeDetail = await _employeeContext.Employees.FindAsync(id);

            return View(getEmployeeDetail);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getEmployeeDetail = await _employeeContext.Employees.FindAsync(id);
            _employeeContext.Employees.Remove(getEmployeeDetail);
            await _employeeContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var getEmployeeDetail = await _employeeContext.Employees.FindAsync(id);
        //    _employeeContext.Employees.Remove(getEmployeeDetail);
        //    await _employeeContext.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
    }

    public class ddValueExample 
    {
        public string employees { get; set; }
    }
}