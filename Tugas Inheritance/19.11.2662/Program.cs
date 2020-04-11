using System;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Hari", 18);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Laksono", 33, 167806, "Guru Fisika");
            teacher.GetNameAndAge();

            Student student = new Student("Zahwa", 19, 19680, "Zahwanawa@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
