using System;
using System.Collections.Generic;

namespace DackAssignment.Models
{
    public partial class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public sbyte Deleted { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
