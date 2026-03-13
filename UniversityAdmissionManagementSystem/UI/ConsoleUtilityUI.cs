using System;

namespace UniversityAdmissionManagementSystem.UI
{
    public class ConsoleUtility
    {
        public static void Header()
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("    University Admission Management System  ");
            Console.WriteLine("*********************************************");
        }

        public static void Pause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}