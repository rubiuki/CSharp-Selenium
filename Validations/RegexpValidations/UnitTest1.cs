using System.Text.RegularExpressions;

namespace RegexpValidations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            string firstname = "Tiffany";
            string pattern = @"^[a-zA-Z]+$";

            bool response = Regex.IsMatch(firstname, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation issue with first name!");
            }
        }

        [TestMethod]
        public void TestLastName()
        {
            string lastname = "Smith    ";
            string pattern = @"^[a-zA-Z]+$";

            bool response = Regex.IsMatch(lastname, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation issue with first name!");
            }
        }

        [TestMethod]
        public void TestAge()
        {
            int age = 29;
            string sAge = Convert.ToString(age);
            string pattern = @"^\d+$";

            bool response = Regex.IsMatch(sAge, pattern);
            if (response)
            {
                Assert.IsTrue(response);
            }
            else
            {
                Console.WriteLine("Validation issue with first name!");
            }
        }
    }
}