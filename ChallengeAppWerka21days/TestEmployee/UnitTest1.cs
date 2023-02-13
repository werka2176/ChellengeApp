using ChellengeAppWerka21days;

namespace TestEmployee
{
    public class Tests
    {

        [Test]
        public void WhenGestSttatisticsCalled_ShouldReturnMax()
        {
            //arrange
            var employee = new Employee("Antoni", "Aniszewski");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(27);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(27, statistics.Max);

        }
        [Test]
        public void WhenGestSttatisticsCalled_ShouldReturnAvarage()
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
        [Test]
        public void WhenGestSttatisticsCalled_ShouldReturnMin()
        {
            //arrange
            var employee = new Employee("Antonina", "Moniszewska");
            employee.AddGrade(7);
            employee.AddGrade(16);
            employee.AddGrade(9);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(7, statistics.Min);

        }
        [Test]
        public void WhenAddGradeIsString_ShouldReturnFloat()
        {
            //arrange
            var employee = new Employee("Antonina", "Aleksiuk");
            employee.AddGrade("12");
            employee.AddGrade("6");
            employee.AddGrade("9");

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Min);
            Assert.AreEqual(12, statistics.Max);
            Assert.AreEqual(9, statistics.Average);

        }
    }
}