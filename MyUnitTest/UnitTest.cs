using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace MyUnitTest;

[TestClass]
public class UnitTest
{
    private int a;
    public TestContext TestContext { get; set; }

    [ClassInitialize]
    public static void ClassInitialize(TestContext testContext)
    {
        Trace.WriteLine("This will run only once after all tests started");
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        Trace.WriteLine("This will run after all tests are over");
    }

    [TestInitialize]
    public void RunBeforeEachTest()
    {
        a = 1;
        Trace.WriteLine("RunBeforeEachTest will execute before each test");
    }

    [TestCleanup]
    public void RunAfterEachTest()
    {
        Trace.WriteLine("RunAfterEachTest will execute after each test");
    }

    [TestMethod]
    [TestCategory("Quiz")]
    public void TestMethod1()
    {
        var a = 1;
        var b = 1;

        Assert.AreEqual(2, a + b);
        Trace.WriteLine(TestContext.CurrentTestOutcome);
    }

    [TestMethod]
    public void TestMethod2()
    {
        Assert.Fail("This test will always fail.");
        Trace.WriteLine(TestContext.TestName);
    }

    [TestMethod]
    [ExpectedException(typeof(AssertFailedException))]
    public void TestMethod3()
    {
        var a = 10;
        var b = 10;
        Assert.IsTrue(a + b == 21);
        Assert.AreEqual(21, a + b);
        Trace.WriteLine(TestContext.TestName);
    }
}