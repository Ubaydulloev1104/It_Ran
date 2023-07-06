using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ubaydulloev.Entiti;

namespace Ubaydulloev.Abstractions.Repositories
{
    internal interface IEmployeRepository
    {
        Employee GetEmployeeID(int employeeId);
        Employee GetEmployeeDepartment(string Department);
        IEnumerable <Employee> GetAll();

        void Delete(Employee employee);
        void Update(Employee employee);
        void Create(Employee employee);



    }
}
