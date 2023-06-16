namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter Student Count: ");
            int studentcount = Convert.ToInt32(Console.ReadLine());

            Student[] student = new Student[studentcount];
            
            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine("Enter Studen Name: ... ");
                string Name = Console.ReadLine();

                Console.WriteLine("Enter Student Grade: ... ");
                int Grade = Convert.ToInt32(Console.ReadLine());

                student[i] = new Student(Name, Grade);

            }

            Console.WriteLine("Max Grade is: " + StatisticsHelper.GetHighestGrade(student));
            Console.WriteLine("Min Grade is: " + StatisticsHelper.GetLowestGrade(student));
            Console.WriteLine("Avarage Grade is: " + StatisticsHelper.GetAvarageGrade(student));

        }
        public class Student
        {
            public Student(string name, int grade)
            {
                Name = name;

                Grade = grade;

            }
            public string Name { get; set; }

            public int Grade { get; set; }


        }
        public static class StatisticsHelper
        {
            public static double GetHighestGrade(Student[] student)
            {
                int HighestGrade = int.MinValue;

                foreach (var Student in student)
                {
                    
                        if (Student.Grade > HighestGrade)
                    {
                        HighestGrade = Student.Grade;
                    }
                    


                }
                return HighestGrade;
            }

            public static double GetLowestGrade(Student[] student)
            {
                int LowestGrade = int.MaxValue;
                foreach (var Student in student)
                {
                    if (Student.Grade < LowestGrade)
                    {
                        LowestGrade = Student.Grade;
                    }
                }
                return LowestGrade;
            }

            public static double GetAvarageGrade(Student[] student)
            {
               int cem = 0;
                foreach (var Student in student)
                {
                    cem +=Student.Grade;
                }
                return (double)cem / student.Length;
            }
        }
    }
}