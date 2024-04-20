using System;
using System.Collections.Generic;

namespace MVC_Crud_operation.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DeptNo { get; set; }
        public string DeptName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
