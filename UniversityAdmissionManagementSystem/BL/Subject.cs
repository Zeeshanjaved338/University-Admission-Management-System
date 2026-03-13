using System;
using System.Collections.Generic;

namespace UniversityAdmissionManagementSystem.BL
{
    public class Subject
    {
        public string code;
        public string type;
        public int creditHours;
        public int fee;

        public Subject(string code, string type, int creditHours, int fee)
        {
            this.code = code;
            this.type = type;
            this.creditHours = creditHours;
            this.fee = fee;
        }
    }
}