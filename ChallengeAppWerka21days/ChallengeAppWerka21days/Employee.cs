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
            var statistics1 = new Statistics();

            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Average += grade;
            }

            statistics1.Average = statistics1.Average / this.grades.Count;
            return statistics1;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Min = float.MaxValue;
            statistics2.Max = float.MinValue;
            statistics2.Average = 0;

            for (int i = 0; i<this.grades.Count; i++)
            {
                statistics2.Min = Math.Min(statistics2.Min, this.grades[i]);
                statistics2.Max = Math.Max(statistics2.Max, this.grades[i]);
                statistics2.Average += this.grades[i];

            }
            statistics2.Average /= this.grades.Count;
            return statistics2;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Min = float.MaxValue;
            statistics3.Max = float.MinValue;
            statistics3.Average = 0;

            var index = 0;
            do
            {
                statistics3.Min = Math.Min(statistics3.Min, grades[index]);
                statistics3.Max = Math.Max(statistics3.Max, grades[index]);
                statistics3.Average += grades[index];
                index++;
            } while (index < this.grades.Count);

            statistics3.Average /= this.grades.Count;
            return statistics3;
        }  

        public Statistics GetStatisticsWithWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Min = float.MaxValue;
            statistics4.Max = float.MinValue;
            statistics4.Average = 0;

            var index = 0;
            while (index < this.grades.Count)
            {
                statistics4.Min = Math.Min(statistics4.Min, grades[index]);
                statistics4.Max = Math.Max(statistics4.Max, grades[index]);
                statistics4.Average += grades[index];
                index++;
            }
            statistics4.Average /= this.grades.Count;
            return statistics4;
        }
    }
}