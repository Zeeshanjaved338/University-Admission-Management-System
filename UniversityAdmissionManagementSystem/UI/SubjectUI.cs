using System;
using UniversityAdmissionManagementSystem.BL;
using UniversityAdmissionManagementSystem.DL;

namespace UniversityAdmissionManagementSystem.UI
{
    public class SubjectUI
    {
        public static void RegisterSubject()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            var student = StudentDL.FindStudent(name);

            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            if (student.regDegree == null)
            {
                Console.WriteLine("Student has no degree admission");
                return;
            }

            Console.WriteLine("Available Subjects:");
            foreach (var sub in student.regDegree.subjects)
            {
                Console.WriteLine(sub.code);
            }

            Console.Write("Enter Subject Code: ");
            string code = Console.ReadLine();

            bool found = false;
            foreach (var sub in student.regDegree.subjects)
            {
                if (sub.code.ToLower() == code.ToLower())
                {
                    if (!student.regSubjects.Contains(sub))
                    {
                        student.regSubjects.Add(sub);
                        Console.WriteLine("Subject Registered!");
                    }
                    else
                    {
                        Console.WriteLine("Subject already registered!");
                    }
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Subject not found in the degree program!");
            }
        }
    }
}