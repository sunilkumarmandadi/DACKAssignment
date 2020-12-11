using System;
using System.Collections.Generic;
using AgriLandPortalAPI.DAL;
using DackAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DackAssignment.Controllers
{
    public class SearchController : Controller
    {
        dalHelper helper;
        [HttpGet]
        public IActionResult Index()
        {
            List<DepartmentSearch> departments = new List<DepartmentSearch>();
            return View("~/Views/Search/Search.cshtml",departments);
        }

        public string Test()
        {
            return "API is working";
        }
        [HttpPost]
        public ActionResult Index(Microsoft.AspNetCore.Http.IFormCollection account )
        {
            List<DepartmentSearch> departments;
            try
            {
                
                using (helper = new dalHelper())
                {
                    departments = helper.Search(account["lastName"], account["deptName"], account["subDeptName"]);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("~/Views/Search/Search.cshtml",departments);
        }
    }
}
