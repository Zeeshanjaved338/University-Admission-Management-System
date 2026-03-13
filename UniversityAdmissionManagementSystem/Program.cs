using System;
using UniversityAdmissionManagementSystem.DL;
using UniversityAdmissionManagementSystem.UI;

namespace UniversityAdmissionManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleUtility.Header();

                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Degree Program");
                Console.WriteLine("3. Generate Merit");
                Console.WriteLine("4. View Registered Students");
                Console.WriteLine("5. View Students of Specific Program");
                Console.WriteLine("6. Register Subjects");
                Console.WriteLine("7. Generate Fee");
                Console.WriteLine("8. Exit");
                Console.WriteLine("========================================");
                Console.Write("Enter Option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        StudentUI.AddStudent();
                        Console.WriteLine("Student Added Successfully!");
                        Console.WriteLine("========================================");
                        break;

                    case 2:
                        DegreeProgramUI.AddDegreeProgram();
                        Console.WriteLine("Degree Program Added Successfully!");
                        Console.WriteLine("========================================");
                        break;

                    case 3:
                        foreach (var s in StudentDL.students)
                        {
                            foreach (var pref in s.preferences)
                            {
                                if (pref.seats > 0 && s.regDegree == null)
                                {
                                    s.regDegree = pref;
                                    pref.seats--;
                                    Console.WriteLine(s.name + " assigned to " + pref.title);
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("Merit Generated and Admissions Assigned!");
                        Console.WriteLine("=========================================");
                        break;

                    case 4:
                        foreach (var s in StudentDL.students)
                        {
                            Console.WriteLine(s.name + " FSC:" + s.fscMarks + " ECAT:" + s.ecatMarks +
                                              " Degree:" + (s.regDegree != null ? s.regDegree.title : "None"));
                        }
                        Console.WriteLine("Total Registered Students: " + StudentDL.students.Count);
                        Console.WriteLine("Total Seats Filled: " + StudentDL.students.FindAll(s => s.regDegree != null).Count);
                        Console.WriteLine("=========================================");
                        break;

                    case 5:
                        Console.Write("Enter Degree Name: ");
                        string degName = Console.ReadLine();
                        bool found = false;
                        foreach (var s in StudentDL.students)
                        {
                            if (s.regDegree != null && s.regDegree.title.ToLower() == degName.ToLower())
                            {
                                Console.WriteLine(s.name);
                                found = true;
                            }
                        }
                        if (!found)
                            Console.WriteLine("No students found in this program.");
                        Console.WriteLine("Total Students in " + degName + ": " + StudentDL.students.FindAll(s => s.regDegree != null && s.regDegree.title.ToLower() == degName.ToLower()).Count);
                        Console.WriteLine("=========================================");
                        break;

                    case 6:
                        SubjectUI.RegisterSubject();
                        Console.WriteLine("Subjects Registered Successfully!");
                        Console.WriteLine("=========================================");
                        break;

                    case 7:
                        foreach (var s in StudentDL.students)
                        {
                            Console.WriteLine(s.name + " Fee: " + s.CalculateFee());
                        }
                        Console.WriteLine("Fees Generated for All Students!");
                        Console.WriteLine("=========================================");
                        break;

                    case 8:
                        return;

                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }

                ConsoleUtility.Pause();
            }
        }
    }
}