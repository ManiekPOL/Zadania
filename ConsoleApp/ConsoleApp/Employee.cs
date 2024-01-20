

using System.Diagnostics;

namespace ConsoleApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(double grade)
        {
            float doubleInFloat = (float)grade;
            this.AddGrade(doubleInFloat);
        }
        public void AddGrade(long grade)
        {
            float longInFloat = (float)grade;
            this.AddGrade(longInFloat);
        }
        public void AddGrade(decimal grade)
        {
            float decimalInFloat = (float)grade;
            this.AddGrade(decimalInFloat);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average = statistics.Average + grade;
                }
            }
            statistics.Average = statistics.Average / this.grades.Count;


            return statistics;

        }
        

        




    }
}
