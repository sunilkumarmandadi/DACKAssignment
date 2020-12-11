using AgriLandPortalAPI.Models;
using DackAssignment.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriLandPortalAPI.DAL
{
    public class dalHelper : IDisposable
    {
        private readonly DackContext dBContext;

        public dalHelper()
        {
        }

        public dalHelper(DackContext appDB)
        {
            this.dBContext = appDB;
        }

        public void Dispose()
        {

        }

        //public void InsertUser(Users registration)
        //{
        //    try
        //    {
        //        using (var context = new agrilandContext())
        //        {
        //            var usr = new Users()
        //            {
        //                UserName = registration.UserName,
        //                UserType = registration.UserType,
        //                Email = registration.Email,
        //                Mobile = registration.Mobile,
        //                Password = registration.Password,
        //                CreatedBy = registration.UserName,
        //                CreatedOn = DateTime.Now,
        //                UpdatedOn = DateTime.Now
        //            };
        //            context.Users.Add(usr);
        //            context.SaveChanges();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<Department> GetDepartments()
        {
            try
            {
                List<Department> departments = new List<Department>();
                using (var context = new DackContext())
                {
                    context.Department.ToList();
                }
                return departments;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DepartmentSearch> Search(string empName, string deptId, string subDeptId)
        {
            try
            {
                List<DepartmentSearch> search = new List<DepartmentSearch>();
                using (var context = new DackContext())
                {

                    var name = new MySqlParameter("@last_name", empName);
                    var department_id = new MySqlParameter("@department_name", deptId);
                    var subdepartment_id = new MySqlParameter("@subdepartment_name", subDeptId);
                    

                    search = context
                                  .DepartmentSearch
                                  .FromSqlRaw("CALL search_employee(@last_name, @department_name, @subdepartment_name)", parameters: new[] { name, department_id, subdepartment_id })
                                  .ToList();

                }
                return search;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
