using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DackAssignment.Models
{
    public class DepartmentSearch
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FbprofileLink { get; set; }
        public string TwitterProfileLink { get; set; }
        public string DepartmentName { get; set; }
        public string SubDepartmentName { get; set; }
        public string Bio { get; set; }

    }

    public class Account
    {
        public string lastName { get; set; }
        public string deptName { get; set; }
        public string subDeptName { get; set; }

    }
}
