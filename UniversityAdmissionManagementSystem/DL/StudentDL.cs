using System;
using System.Collections.Generic;
using UniversityAdmissionManagementSystem.BL;

namespace UniversityAdmissionManagementSystem.DL
{
    public class StudentDL
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent(Student s)
        {
            students.Add(s);
        }

        public static Student FindStudent(string name)
        {
            foreach (var s in students)
            {
                if (s.name.ToLower() == name.ToLower())
                    return s;
            }
            return null;
        }
    }
}