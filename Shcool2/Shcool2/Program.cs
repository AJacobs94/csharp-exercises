using System;

namespace School2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Course
    {
        public string courseName { get; set; }


    }

    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            StudentId = nextStudentId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;

        }

        public Student(string name, int studentId)
            : this(name, studentId, 0, 0) { }

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {// Update the appropriate properties: NumberOfCredits, Gpa
            double qualityScore;
            if (grade > 89.9)
            {
                qualityScore = 4.0 * courseCredits;

            }
            if (grade > 79.9 || grade < 89.9)
            {
                qualityScore = 3.0 * courseCredits;
            }
            if (grade > 69.9 || grade < 79.9)
            {
                qualityScore = 2.0 * courseCredits;
            }
            if (grade > 59.9 || grade < 69.9)
            {
                qualityScore = 1.0 * courseCredits;
            }
            else
            {
                qualityScore = 0;
            }
            double oldQualityScore = Gpa * NumberOfCredits;
            NumberOfCredits += courseCredits;
            Gpa = (qualityScore + oldQualityScore) / NumberOfCredits;



        }

        public string GetGradeLevel()
        {
            // Determine the grade level of the student based on NumberOfCredits
            string gradeLevel;
            if (NumberOfCredits > 0 || NumberOfCredits <= 29)
            {
                gradeLevel = "Freshman";
            }
            if (NumberOfCredits > 29 || NumberOfCredits <= 59)
            {
                gradeLevel = "Sophomore";
            }
            if (NumberOfCredits > 59 || NumberOfCredits <= 89)
            {
                gradeLevel = "Junior";
            }
            if (NumberOfCredits > 89)
            {
                gradeLevel = "Senior";
            }
            else
            {
                gradeLevel = "Error";
            }
            return gradeLevel;
        }
        public override bool Equals(object obj)
        {
            var studentObj = obj as Student;
            return StudentId == studentObj.StudentId;
        }
        public override string ToString()
        {
            return Name + "(Credits:" + NumberOfCredits + ",GPA:" + Gpa + ")";
        }
        public override int GetHashCode()
        {
            return StudentId;
        }
    }
}

    
