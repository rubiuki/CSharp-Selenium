namespace TicketCreation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime dateTime = DateTime.Now;
            BasketBallTicket ticket = new BasketBallTicket(dateTime, "Manhattan", "Big competition", "Bears", "Wolves");
            Console.WriteLine(ticket);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DateTime dateTime = DateTime.Now;
            PlayTicket ticket = new PlayTicket(dateTime, "Garnier", "Rome and Juliet", "drama");
            Console.WriteLine(ticket);
        }

        [TestMethod]    
        public void TestMethod3()
        {
            DateTime dateTime = DateTime.Now;
            MusicalTicket ticket = new MusicalTicket(dateTime, "Shene", "Summer 2023", "Zivert");
            Console.WriteLine(ticket);
        }
    }
}