using NUnit.Framework;

namespace Tests {
    public class Lab2Tests {
        Laboratoria2 lab2 = new Laboratoria2();

        [Test]
        public void AddTests() {
            Assert.AreEqual(0, lab2.Add(0, 0), "0+0=0");
            Assert.AreEqual(10, lab2.Add(5, 5), "5+5=10");
            Assert.AreEqual(-3, lab2.Add(-10, 7), "-10+7=-3");
        }
    }
}