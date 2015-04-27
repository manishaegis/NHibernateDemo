using NHibernate.Linq;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Transform;

namespace TestAppLinq
{
    public class EmployeeManagement
    {
        public static List<Employee> GetAllEmployees(ISession objISession)
        {

            List<Employee> employees = objISession.Query<Employee>().ToList();
            return employees;

        }

        public static List<Employee> GetEmployees(ISession objISession)
        {

            List<Employee> employees = objISession.Query<Employee>().ToList();
            return employees;

        }

        public static List<Employee> GetResultFromSP(ISession session)
        {
            IQuery query = session.CreateSQLQuery("Exec usp_GetEmployeesByProjectId @ProjectId=:ProjectId")
                    .SetInt16("ProjectId", 1)
                    .SetResultTransformer(Transformers.AliasToBean<Employee>());

            return query.List<Employee>().ToList();

        }
    }
}