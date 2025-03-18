using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_18_2025_task
{
    public class Group
    {
        public string Name { get; set; }
        public string Shift { get; set; }
        public Student[] Students { get; set; }


        private Group()
        {
            Students = new Student[0];
        }

        public Group(string name, string shift) : this()
        {
            Name = name;
            Shift = shift;
        }

        public void AddStudent(Student student)
        {
            if (student.GroupName.ToLower() == Name.ToLower())
            {
                Student[] newStudents = new Student[Students.Length + 1];
                for (int i = 0; i < Students.Length; i++)
                {
                    newStudents[i] = Students[i];
                }
                newStudents[Students.Length] = student;
                Students = newStudents;
                Console.WriteLine($"{student.Name} {student.Surname} {Name} qrupuna elave edildi");
                return;
            }
            Console.WriteLine($"{student.Name} {student.Surname} {student.GroupName} qrupunun telebesidir ve {Name} qrupuna elave edilmedi");
        }

        public bool IsStudentInGroup(string name)
        {
            foreach (Student student in Students)
                if (student.Name == name)
                    return true;
            return false;
        }
    }
}
