using Microsoft.SqlServer.Server;
using System;
namespace Week1
{
    enum Department { CSE, EEE, BBA }

    struct Address {
        public string city;
        public string zip;
    }

    class Student
    {
        public const string university = "AIUB";
        public readonly int StudentID;

        public string name;
        public int age;
        public double CGPA;
        public bool passed;
        public char section;

        public Student(string name, int age, int id)
        {
            StudentID = id;
            this.name = name;
            this.age = age;
        }

        public static int SuMarks(params int[] marks)
        {
            int sum = 0;
            foreach (int m in marks)
            {
                sum += m;
            }
            return sum;
        }
        public static void increaseAge(ref int age)
        {
            age++;
        }
        public static void GetResult(out string grade, out bool pass)
        {
            grade = "A";
            pass = true;
        }
    }


}