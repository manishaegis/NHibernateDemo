using System;
using System.Text;
using System.Collections.Generic;


namespace TestAppLinq {
    
    public class Employee {
        public Employee() { }
        public virtual int EmployeeId { get; set; }
        public virtual Department Department { get; set; }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual DateTime DateOfJoin { get; set; }
        public virtual bool Married { get; set; }
    }
}
