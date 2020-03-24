using NUnit.Framework;

namespace Tests {
    public class Lab2Tests {
        Laboratoria2 lab2 = new Laboratoria2();

        [Test]
        public void Zad1_AddTests() {
            Assert.AreEqual(0, lab2.Add(0, 0), "0+0=0");
            Assert.AreEqual(10, lab2.Add(5, 5), "5+5=10");
            Assert.AreEqual(-3, lab2.Add(-10, 7), "-10+7=-3");
        }

        [Test]
        public void Zad2_IsGreaterThanZeroTests() {
            Assert.AreEqual(false, lab2.IsGreaterThanZero(-4), "-4<0");
            Assert.AreEqual(false, lab2.IsGreaterThanZero(0), "0==0");
            Assert.AreEqual(true, lab2.IsGreaterThanZero(3), "3>0");
            Assert.AreEqual(true, lab2.IsGreaterThanZero(6), "6>0");
        }

        [Test]
        public void Zad3_GetOfficialGreetingTests() {
            Assert.AreEqual("Towarzyszy nam dziœ pan Adam", lab2.GetOfficialGreeting("Adam"));
            Assert.AreEqual("Towarzyszy nam dziœ pan Aleks", lab2.GetOfficialGreeting("Aleks"));
            Assert.AreEqual("Towarzyszy nam dziœ pani Zosia", lab2.GetOfficialGreeting("Zosia"));
            Assert.AreEqual("Towarzyszy nam dziœ pani Renata", lab2.GetOfficialGreeting("Renata"));
        }

        [Test]
        public void Zad4_AreEqual() {
            Assert.AreEqual(true, lab2.AreEqual(0, 0), "0==0");
            Assert.AreEqual(true, lab2.AreEqual(5, 5), "5==5");
            Assert.AreEqual(false, lab2.AreEqual(10, 7), "10!=7");
        }
    }
}