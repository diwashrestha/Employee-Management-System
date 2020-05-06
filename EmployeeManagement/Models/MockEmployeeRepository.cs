using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private  List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Marry", Department = "HR", Email = "mary@diwash.com" },
                new Employee() { Id = 2, Name = "Carry", Department = "RH", Email = "cary@diwash.com" },
                new Employee() { Id = 3, Name = "Larry", Department = "ER", Email = "lary@diwash.com" }
            };
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }

}
