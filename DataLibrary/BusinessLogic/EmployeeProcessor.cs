using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName,
            string lastName, string emailAdress)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAdress = emailAdress
            };

            string sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAdress)
                           values (@EmployeeId, @FirstName, @LastName, @EmailAdress);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id, EmployeeId, FirstName, LastName, EmailAdress
                           from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
