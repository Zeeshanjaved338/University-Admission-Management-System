using System;
using System.Collections.Generic;

namespace UniversityAdmissionManagementSystem.BL
{
    public class DegreeProgram
    {
        public string title;
        public int duration;
        public int seats;
        public List<Subject> subjects;

        public DegreeProgram(string title, int duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<Subject>();
        }

        public void AddSubject(Subject s)
        {
            subjects.Add(s);
        }
    }
}