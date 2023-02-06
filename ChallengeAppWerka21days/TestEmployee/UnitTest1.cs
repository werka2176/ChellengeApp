using ChellengeAppWerka21days;

namespace TestEmployee
{
    public class Tests
    {

        [Test]
        public void MaxAndMinGrades_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new Employee("Antoni", "Aniszewski");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(27);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(27, statistics.Max);
        }
        [Test]
        public void AvergeFromGrades_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new Employee("Antonina", "Moniszewska");
            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(9);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Average);

        }
    }
}