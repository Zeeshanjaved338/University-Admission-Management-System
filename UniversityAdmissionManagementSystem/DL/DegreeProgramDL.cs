using System;
using System.Collections.Generic;
using UniversityAdmissionManagementSystem.BL;

namespace UniversityAdmissionManagementSystem.DL
{
    public class DegreeProgramDL
    {
        public static List<DegreeProgram> programs = new List<DegreeProgram>();

        public static void AddProgram(DegreeProgram d)
        {
            programs.Add(d);
        }

        public static DegreeProgram FindProgram(string name)
        {
            foreach (var d in programs)
            {
                if (d.title.ToLower() == name.ToLower())
                    return d;
            }
            return null;
        }
    }
}