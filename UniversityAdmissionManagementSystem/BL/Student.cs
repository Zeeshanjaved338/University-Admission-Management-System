using System;
using System.Collections.Generic;

namespace UniversityAdmissionManagementSystem.BL
{
    public class Student
    {
        public string name;
        public int age;
        public int fscMarks;
        public int ecatMarks;
        public List<DegreeProgram> preferences;
        public DegreeProgram regDegree;
        public List<Subject> regSubjects;

        public Student(string name, int age, int fscMarks, int ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            preferences = new List<DegreeProgram>();
            regSubjects = new List<Subject>();
        }

        public float CalculateMerit()
        {
            return (fscMarks * 0.5f) + (ecatMarks * 0.5f);
        }

        public int CalculateFee()
        {
            int total = 0;
            foreach (var s in regSubjects)
                total += s.fee;
            return total;
        }
    }
}