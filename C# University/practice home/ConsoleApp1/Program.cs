namespace StudenntManaagementSystem
{
    enum BloodGroup
    {
        A,
        B,
        AB,
        O
    }

    struct Address
    {
        public string City;
        public string Country;
        public Address (string City, string Country)
        {
            this.City = City;
            this.Country = Country;
        }
    }

    class Student
    {
        private int Id;
        private string Name;
        public int Age;
        public double CGPA;
        public BloodGroup BloodGroup;
        public Address Address;
        public const string UniversityName = "AIUB";
        public readonly int AdmissionYear;
        public int[] marks;

        public int id {
            get { return Id; }
            set { Id = value; }
        }
        public string name {
            get { return Name; }
            set { Name = value; }
        }

        public Student (int Id, string Name, int Age, double CGPA, BloodGroup BloodGroup,
            Address Address, int AdmissionYear, int[] marks)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.CGPA = CGPA;
            this.BloodGroup = BloodGroup;
            this.Address = Address;
            this.AdmissionYear = AdmissionYear;
            this.marks = marks;
        }

        public Student (Student newST)
        {
            this.Id = newST.Id;
            this.Name = newST.Name;
            this.Age = newST.Age;
            this.CGPA = newST.CGPA;
            this.BloodGroup = newST.BloodGroup;
            this.Address = newST.Address;
            this.AdmissionYear = newST.AdmissionYear;
        }

        public virtual void DisplayInfo() {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"CGPA: {CGPA}");
            Console.WriteLine($"Blood Group: {BloodGroup}");
            Console.WriteLine($"Address: {Address.City}, {Address.Country}");
            Console.WriteLine($"Admission Year: {AdmissionYear}");
        }

        public double Avg (params double[] numbers)
        {
            double avg = 0;
            double sum = 0;
            foreach (double i in numbers)
            {
                sum += i;
            }
            avg = sum / numbers.Length;
            return avg;
        }

        public void AgeIncrease(ref int Age)
        {
            Age += 1;
        }

        public void Grade (out double Grade)
        {
            Grade = CGPA;
        }

        
        

    }

    class GraduateStudent : Student
    {
        public string ResearchTopic;
        public GraduateStudent(string ResearchTopic, int Id, string Name, int Age, double CGPA, BloodGroup BloodGroup,
            Address Address, int AdmissionYear, int[] marks) : base(Id, Name, Age, CGPA, BloodGroup, Address, AdmissionYear, marks)
        {
            this.ResearchTopic = ResearchTopic;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Research Topic: {ResearchTopic}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Id, Name, Age, CGPA, BloodGroup, Address, AdmissionYear");
            Student s1 = new Student(101, "Ahnaf Hossain", 21, 4.00, BloodGroup.A, new Address("Dhaka", "Bangladesh"), 2026,new int[]{ 10,50,60} );
            Student s2 = new Student(s1);
            GraduateStudent s3 = new GraduateStudent("AI", 101, "Ahnaf Hossain", 21, 4.00, BloodGroup.A, new Address("Dhaka", "Bangladesh"), 2026, new int[] { 10, 50, 60 });

            s1.DisplayInfo();
            s2.DisplayInfo();
            s3.DisplayInfo();
            Console.WriteLine($"Average Number: {s1.Avg(55,80,85,90)}");
            Console.WriteLine($"Age: {s1.Age}");
            s1.AgeIncrease(ref s1.Age);
            Console.WriteLine($"Increased age: {s1.Age}");
            double s1Grade;
            s1.Grade(out s1Grade);
            Console.WriteLine($"Student Grade: {s1Grade}");

            int[,] Allmarks = { {50,60 },{70,80 } }; // row = student, col = marks

            // row = student, col = marks for each sub.
            int[][] StudentDifMarks = { 
                new int[] { 50,60,70 },
                new int[] { 99,50,98,100 }
            };

            foreach (int[] i in StudentDifMarks) { 
                foreach (int j in i)
                {
                    Console.WriteLine(j + " ");
                }
            }
        }
    }
}
