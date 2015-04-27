using System;
using System.Text;
using System.Collections.Generic;


namespace TestAppLinq {

    public class vwEmployeeWorkDetail
    {
        public virtual int EmployeeId { get; set; }
        public virtual string Name { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual string DepartmentName { get; set; }
    }
}
