using System;
using UniversityAdmissionManagementSystem.BL;
using UniversityAdmissionManagementSystem.DL;

namespace UniversityAdmissionManagementSystem.UI
{
    public class StudentUI
    {
        public static void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter FSC Marks: ");
            int fsc = int.Parse(Console.ReadLine());

            Console.Write("Enter ECAT Marks: ");
            int ecat = int.Parse(Console.ReadLine());

            Student s = new Student(name, age, fsc, ecat);

            Console.WriteLine("Available Degree Programs:");
            foreach (var d in DegreeProgramDL.programs)
                Console.WriteLine(d.title);

            Console.Write("Enter number of preferences: ");
            int pref = int.Parse(Console.ReadLine());

            for (int i = 0; i < pref; i++)
            {
                string degreeName = Console.ReadLine();
                var d = DegreeProgramDL.FindProgram(degreeName);
                if (d != null)
                    s.preferences.Add(d);
            }

            StudentDL.AddStudent(s);
        }
    }
}