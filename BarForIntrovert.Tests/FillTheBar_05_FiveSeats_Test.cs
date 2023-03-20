using NUnit.Framework;

namespace BarForIntrovert.Tests {
    [TestFixture]
    class FillTheBar_05_FiveSeats_Test {
        [Test]
        public void FiveSeats_FirstTaken_Test() {
            var seats = new bool[] {
                true, false, false, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true, false, true }, seats);
        }

        [Test]
        public void FiveSeats_SecondTaken_Test() {
            var seats = new bool[] {
                false, true, false, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { false, true, false, false, true }, seats);
        }

        [Test]
        public void FiveSeats_ThirdTaken_Test() {
            var seats = new bool[] {
                false, false, true, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true, false, true }, seats);
        }

        [Test]
        public void FiveSeats_ForthTaken_Test() {
            var seats = new bool[] {
                false, false, false, true, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, false, true, false }, seats);
        }

        [Test]
        public void FiveSeats_FifthTaken_Test() {
            var seats = new bool[] {
                false, false, false, false, true
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true, false, true }, seats);
        }
    }
}
