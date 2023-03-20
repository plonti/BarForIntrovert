using NUnit.Framework;

namespace BarForIntrovert.Tests {
    [TestFixture]
    class FillTheBar_03_ThreeSeats_Test {
        [Test]
        public void ThreeSeats_FirstTaken_Test() {
            var seats = new bool[] {
                true, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true }, seats);
        }

        [Test]
        public void ThreeSeats_SecondTaken_Test() {
            var seats = new bool[] {
                false, true, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { false, true, false }, seats);
        }

        [Test]
        public void ThreeSeats_ThirdTaken_Test() {
            var seats = new bool[] {
                false, false, true
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true }, seats);
        }
    }
}
