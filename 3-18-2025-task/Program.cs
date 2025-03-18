using System.Text;

namespace _3_18_2025_task
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Tural", "Tahmazli", "Male", new DateTime(2005, 2, 13), "+994558505780", 23, "BB208");
            Student student2 = new Student("Peter", "Parker", "Male", new DateTime(2001, 8, 10), "+994558505780", 23, "HB211");
            Group group = new Group("BB208", "idk");
            group.AddStudent(student1);
            group.AddStudent(student2);
            Console.WriteLine();

            Console.WriteLine(group.IsStudentInGroup("Tural"));
            Console.WriteLine(group.IsStudentInGroup("Peter"));

            Console.WriteLine();
            foreach (var s in group.Students)
            {
                Console.WriteLine(s);
                Console.WriteLine();
                for (int i = 0; i < 30; i++)
                    s.Absent();
                Console.WriteLine(s.Limit);
                Console.WriteLine();
            }
        }
    }
}
