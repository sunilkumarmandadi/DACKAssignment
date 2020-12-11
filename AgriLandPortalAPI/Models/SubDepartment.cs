using System;
using System.Collections.Generic;

namespace DackAssignment.Models
{
    public partial class SubDepartment
    {
        public int SubDepartmentId { get; set; }
        public int DepartmentId { get; set; }
        public string SubDepartmentName { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public sbyte Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
