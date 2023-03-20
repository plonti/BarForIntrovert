using NUnit.Framework;

namespace BarForIntrovert.Tests {
    [TestFixture]
    class FillTheBar_04_FourSeats_Test {
        [Test]
        public void FourSeats_FirstTaken_Test() {
            var seats = new bool[] {
                true, false, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, false, true }, seats);
        }

        [Test]
        public void FourSeats_SecondTaken_Test() {
            var seats = new bool[] {
                false, true, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { false, true, false, true }, seats);
        }

        [Test]
        public void FourSeats_ThirdTaken_Test() {
            var seats = new bool[] {
                false, false, true, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true, false }, seats);
        }

        [Test]
        public void FourSeats_ForthTaken_Test() {
            var seats = new bool[] {
                false, false, false, true
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, false, true }, seats);
        }
    }
}
