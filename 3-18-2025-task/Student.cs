using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_18_2025_task
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public int Limit { get; set; }
        public string GroupName { get; set; }

        public Student(string name, string surname, string gender, DateTime birthDate, string phoneNumber, int limit, string groupName)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
            Limit = limit;
            GroupName = groupName;
        }

        public void Absent()
        {
            if (Limit > 0)
            {
                Limit--;
                Console.WriteLine("Telebe bu gun derse gelmeyib");
                return;
            }
            Console.WriteLine("Kesildiniz.");
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nGender: {Gender}\nBirthDate: {BirthDate.ToShortDateString()}\nPhoneNumber: {PhoneNumber}\nLimit: {Limit}\nGroupName: {GroupName}";
        }
    }
}
