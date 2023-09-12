using System;
using System.Xml.Schema;

namespace CSharpLesson3
{
    class Student
    {
        string fullName;
        int age;
        string email;
        float programmingPoints;
        float mathPoints;
        float physicsPoints;

        public Student(string fullName, int age, string email, float programmingPoints, float mathPoints, float physicsPoints)
        {
            this.fullName = fullName;
            this.age = age;
            this.email = email;
            this.programmingPoints = programmingPoints;
            this.mathPoints = mathPoints;
            this.physicsPoints = physicsPoints;
        }

        public void consoleWrite()
        {
            string pattern = "ФИО: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3:f} \nБаллы по математике: {4:f} \nБаллы по физике: {5:f}";

            Console.WriteLine(pattern, fullName, age, email, programmingPoints, mathPoints, physicsPoints);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Шукурова Гелана Станиславовна";
            int age = 22;
            string email = "36178@email.com";
            float programmingPoints = 90.012F;
            float mathPoints = 79.735F;
            float physicsPoints = 84.368F;

            Student student = new Student(fullName, age, email, programmingPoints, mathPoints, physicsPoints);
            student.consoleWrite();

            Console.ReadKey();
        }
    }
}