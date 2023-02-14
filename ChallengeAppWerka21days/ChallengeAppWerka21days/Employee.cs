using ChallengeAppWerka21days;

namespace ChellengeAppWerka21days
{

    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public void AddGrade(float grade)
        {
            int valueInInt = (int)grade;

            if (grade >= 0 && grade <= 100)

            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Pracownik może otrzymać jednorazowo maksymalnie 100 punktów.");
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
        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public Statistics GetStatisticsForEach()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            for (int i = 0; i<this.grades.Count; i++)
            {
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Average += this.grades[i];

            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            var index = 0;
            do
            {
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Average += grades[index];
                index++;
            } while (index < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }  

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            var index = 0;
            while (index < this.grades.Count)
            {
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Average += grades[index];
                index++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}