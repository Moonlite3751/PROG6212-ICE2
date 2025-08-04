using prjICE_Task2;
namespace TestThunderbolts
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void testAge()
        {
            Thunderbolts t = new Thunderbolts(25, "John Walker", "Super soldier", "US Agent", "Asshole");
            Assert.AreEqual(t[0], 25);
        }

        [TestMethod]
        public void testName()
        {
            Thunderbolts t = new Thunderbolts(30, "Bob Reynolds", "A million explosive suns", "The Sentry", "Shy");
            Assert.AreEqual(t["name"], "Bob Reynolds");
        }

        [TestMethod]
        public void testPower()
        {
            Thunderbolts t = new Thunderbolts(32, "Yelena Belova", "Elite combat, espionage", "White Widow", "Blunt");
            Assert.AreEqual(t[2], "Elite combat, espionage");
        }

        [TestMethod]
        public void testChangedHeroName()
        {
            Thunderbolts t = new Thunderbolts(30, "Bob Reynolds", "A million explosive suns", "The Sentry", "Shy");
            t[3] = "The Void";
            Assert.AreEqual(t["heroName"], "The Void");
        }

        [TestMethod]
        public void testHeroName()
        {
            Thunderbolts t = new Thunderbolts(30, "Alexei Shostakov", "Super strength, combat skills", "Alexei", "Loud");
            t[3] = "Red Guardian";
            Assert.AreEqual(t["heroName"], "Red Guardian");
        }
    }
}
