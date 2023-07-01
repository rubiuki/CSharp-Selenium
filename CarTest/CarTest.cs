namespace CarTest
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void Class_Car_Color_Set()
        {
            Car car = new Car("Red", 2, true);

            StringAssert.Equals(car.Color, "Red");
        }
    }
}