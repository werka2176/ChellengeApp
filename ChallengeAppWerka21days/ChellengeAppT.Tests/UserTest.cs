using System.Reflection.Metadata;

namespace ChellengeAppT.Tests
{
    public class Tests
    {
      
        [Test]
        public void WhenUserCollectTwoPoints_ShouldReturnCorrectResult1()
        {
            //arrange
            var employee = new Employee("weronika", "sawicka", 28);
            employee.AddScore(6);
            employee.AddScore(8);
            employee.SubtractScore(10);
            employee.SubtractScore(5);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-1, result);

        }
    }
}