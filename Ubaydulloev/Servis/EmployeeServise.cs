using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ubaydulloev.Abstractions.Repositories;
using Ubaydulloev.Abstractions.Serves;
using Ubaydulloev.Entiti;
using Ubaydulloev.Repositore;

namespace Ubaydulloev.Servis
{
    public class EmplomeServise
    {
     IEmployeRepository employeRepository;
        IEmailSenderService emailSenderService;
        public EmplomeServise()
        {
            employeRepository = new EmployeeRepository();
            emailSenderService = new EmailSenderService();
        }


        public IEnumerable GetAll()
        {
          var emp=employeRepository.GetAll();
            return emp;
            
        }
        public void Create(Employee employee)
        {
           employeRepository.Create(employee);
           emailSenderService.SendEmail($"Welcome to company {employee.Name}",employee.Email);
        }
        public void Delete(Employee employee)
        {
            employeRepository.Delete(employee);
        }
        public Employee GetEmployeeDepartment(string Department)
        {
           var emp=employeRepository.GetEmployeeDepartment(Department);
            if (emp!= null)
            {
                throw new Exception();
            }
            return emp;
        }
        public Employee GetEmployeeID(int employeeId)
        {
            var emp = employeRepository.GetEmployeeID(employeeId);
            if (emp != null)
            {
                throw new Exception();
            }
            return emp;
        }
        public void Update(Employee employe)
        {
            employeRepository.Update(employe);
        }
    }

}
