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
            var statistics = employee.GetStatisticsForEach();

            //assert
            Assert.AreEqual(27, statistics.Max);

        }
    }
}
        
       