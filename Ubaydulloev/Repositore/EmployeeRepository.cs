using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ubaydulloev.Abstractions.Repositories;
using Ubaydulloev.Entiti;

namespace Ubaydulloev.Repositore
{
    public class EmployeeRepository : IEmployeRepository
    {
        List<Employee> employees;

        public void Create(Employee employee)
        {
          employees.Add(employee);
        }

        public void Delete(Employee employee)
        {
           var emp=employees.SingleOrDefault(x => x.Id ==employee.Id);
            if (emp != null)
            {
                employees.Remove(emp);
            }
            else
            {
                Console.WriteLine("Не найдино");
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetEmployeeDepartment(string Department)
        {
            var emp = employees.SingleOrDefault(n => n.Department == Department);
            return emp;
        }

        public Employee GetEmployeeID(int employeeId)
        {
            var emp =employees.SingleOrDefault(n=>n.Id == employeeId);
            return emp;
        }
        public void Update(Employee employe)
        {
            var emp=employees.SingleOrDefault(n=>n.Id==employe.Id);
            if (emp != null)
            {
                emp.Name= employe.Name;
                emp.Id= employe.Id;
                emp.Email= employe.Email;
                emp.Address= employe.Address;
                emp.UserName= employe.UserName;
                emp.Password= employe.Password;
                emp.Salaru= employe.Salaru;
                emp.Position= employe.Position;
            }
            else
            {
                Console.WriteLine("Не такое Employee");
            }
        }
    }
}