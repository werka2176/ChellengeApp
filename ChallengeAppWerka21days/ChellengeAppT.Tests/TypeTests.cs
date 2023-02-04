namespace ChellengeAppT.Tests
{
    public class TypeTests
    {
        [Test]
        public void NumberShouldReturnDifferentDight()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act


            //assert
            Assert.AreNotEqual(number1, number2); 
        }
        [Test]
        public void GetUserShouldReturnDifferentUser()
        {
            //arrange
            var employee1 = GetUser("weronika", "sawicka", 29);
            var employee2 = GetUser("weronika", "kowalczyk", 30);

            //act


            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetUser(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

    }
}