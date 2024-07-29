using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Pilot emp = new Pilot(1, "Leon", "Potgieter", "Mango", 800.00);
            Assert.AreEqual(emp[0], 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Pilot emp = new Pilot(1, "Leon", "Potgieter", "Mango", 800.00);
            emp[1] = "Reece";
            Assert.AreEqual(emp[1], "Reece");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Pilot emp = new Pilot(1, "Leon", "Potgieter", "Mango", 800.00);
            Assert.AreEqual(emp[2], "Potgieter");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Pilot emp = new Pilot(1, "Leon", "Potgieter", "Mango", 800.00);
            emp[3] = "SA Airlines";
            Assert.AreEqual(emp[3], "SA Airlines");
        }

        [TestMethod]
        public void TestMethod5()
        {
            Pilot emp = new Pilot(1, "Leon", "Potgieter", "Mango", 800.00);
            Assert.AreEqual(emp[4], 800.00);
        }
    }
}