namespace Employee
{
    [TestClass]
    public class EmployeeTest
    {
        Employee employee = new Employee("Rubina", "Sukiasyan");
        [TestMethod]
        public void Employee_Check_FullName()
        {
            string fullName = employee.getFullName();
            StringAssert.Equals(fullName, "Rubina Sukiasyan");
        }
        [TestMethod]
        public void Employee_Check_FullName2() {
            string fullName = employee.getFullNameForSorting();
            StringAssert.Equals(fullName, "Sukiasyan, Rubina");
        }
    }
}