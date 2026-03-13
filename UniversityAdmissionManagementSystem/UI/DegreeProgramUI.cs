using System;
using UniversityAdmissionManagementSystem.BL;
using UniversityAdmissionManagementSystem.DL;

namespace UniversityAdmissionManagementSystem.UI
{
    public class DegreeProgramUI
    {
        public static void AddDegreeProgram()
        {
            Console.Write("Enter Degree Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Degree Duration: ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Enter Seats for Degree: ");
            int seats = int.Parse(Console.ReadLine());

            DegreeProgram d = new DegreeProgram(name, duration, seats);

            Console.Write("Enter how many subjects to add: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Subject Code: ");
                string code = Console.ReadLine();

                Console.Write("Enter Subject Type: ");
                string type = Console.ReadLine();

                Console.Write("Enter Credit Hours: ");
                int ch = int.Parse(Console.ReadLine());

                Console.Write("Enter Subject Fee: ");
                int fee = int.Parse(Console.ReadLine());

                Subject s = new Subject(code, type, ch, fee);
                d.AddSubject(s);
            }

            DegreeProgramDL.AddProgram(d);
        }
    }
}