using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Student
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
    }
    public class StudentService
    {
        private List<Student> students=new List<Student>();

        public List<Student> GetAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{ student.Id} {student.FirstName}{student.LastName}{student.DateOfBirth}");
            }
            return students;
        }
        public void AddStudent(int Id,string FirstName,string LastName,string DateOfBirth) 
        {
            if (students.Any(x => x.Id == Id))
            {
                throw new InvalidOperationException("Student with the same Id already exist.");
            }

            var newStudent = new Student()
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                DateOfBirth = DateOfBirth
            };

            students.Add(newStudent);
        }
        public void RemoveStudent(int id) 
        {
            var studentToRemove = students.FirstOrDefault(x => x.Id == id);
            if (studentToRemove == null)
            {
                throw new InvalidOperationException("Student with given Id does not exist.");
            }
            students.Remove(studentToRemove);
        }
        public void AddStudents(Student[] newStudents)
        {
            foreach (var student in newStudents)
            {
                if (students.Any(x => x.Id == student.Id))
                {
                    throw new InvalidOperationException("Student with the same Id already exist.");
                }
            }

            students.AddRange(newStudents);
        }

        public void RemoveStudents(Student[] studentsToRemove)
        {
            foreach (var student in studentsToRemove)
            {
                var studentToRemove = students.FirstOrDefault(x => x.Id == student.Id);

                if (studentToRemove == null)
                {
                    throw new InvalidOperationException("Student with given Id does not exist.");
                }

                students.Remove(studentToRemove);
            }
        }
    }
}
