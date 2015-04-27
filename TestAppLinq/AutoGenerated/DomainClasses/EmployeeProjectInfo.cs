using System;
using System.Text;
using System.Collections.Generic;


namespace TestAppLinq {

    public class EmployeeProjectInfo
    {
        public virtual int EmployeeProjectInfoId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Project Project { get; set; }
        public virtual bool IsActive { get; set; }
    }
}
