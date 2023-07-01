namespace LoanProgram
{
    [TestClass]
    public class LoanTest
    {
        [TestMethod]
        public void AutoLoan()
        {
            AutoLoan autoLoan = new AutoLoan("155", "Ruby", "Van", .075, 12000, 4, 2015, "C class", "Mercedes", "Metallic");
            decimal calculation = autoLoan.CalculateInterest();
            Assert.AreEqual(2925, calculation);
            Console.WriteLine(autoLoan.ToString());
        }

        [TestMethod]
        public void HomeLoan()
        {
            HomeLoan homeLoan = new HomeLoan("120", "Ruby", "Van", .035, 210000, 30, "Los Angeles", 2010, 15000);
            decimal calculation = homeLoan.CalculateInterest();
            Assert.AreEqual(3010, calculation );
            Console.WriteLine(homeLoan.ToString());
        }
    }
}
