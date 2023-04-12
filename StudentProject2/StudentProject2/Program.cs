using System;

namespace StudentProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student(10, "Lior", 90.2);
            Student S2 = new Student(15, "Ruth", 98);
            Student S3 = new Student(14, "Ron", 94.7);
            AllStudent AS = new AllStudent();

            AS.AddStudent(S1);
            AS.AddStudent(S2);
            AS.AddStudent(S3);

            Console.WriteLine(AS);
        }
    }
}