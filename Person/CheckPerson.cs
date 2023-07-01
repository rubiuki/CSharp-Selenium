using Microsoft.VisualBasic;

namespace Arrays
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void Check_Person_Student_Rel()
        {
            DateTime dateOfBirth = new DateTime(1997, 1, 4);
            //Person person = new Person("1234", "Sukiasyan", "Rubina", 26);
            Student student = new Student("1111", "Petrosyan", "Ashot", 25, dateOfBirth, "Data Science", "9999");

            string mystr = student.Exercise();
        }

        [TestMethod]
        public void Check_Protected()
        {
            DateTime dateOfBirth = new DateTime(1997, 1, 4);
            Student student = new Student("1111", "Petrosyan", "Ashot", 25, dateOfBirth, "Data Science", "9999");
            student.GetDob();
        }

    }
}