using NUnit.Framework;

namespace BarForIntrovert.Tests {
    [TestFixture]
    class FillTheBar_06_SixSeats_Test {
        [Test]
        public void SixSeats_FirstTaken_Test() {
            var seats = new bool[] {
                true, false, false, false, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true, false, false, true }, seats);
        }

        [Test]
        public void SixSeats_SecondTaken_Test() {
            var seats = new bool[] {
                false, true, false, false, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { false, true, false, true, false, true }, seats);
        }

        [Test]
        public void SixSeats_ThirdTaken_Test() {
            var seats = new bool[] {
                false, false, true, false, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true, false, false, true }, seats);
        }

        [Test]
        public void SixSeats_ForthTaken_Test() {
            var seats = new bool[] {
                false, false, false, true, false, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, false, true, false, true }, seats);
        }

        [Test]
        public void SixSeats_FifthTaken_Test() {
            var seats = new bool[] {
                false, false, false, false, true, false
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true, false, true, false }, seats);
        }

        [Test]
        public void SixSeats_SeventhTaken_Test() {
            var seats = new bool[] {
                false, false, false, false, false, true
            };
            Helper.FillTheBar(seats);
            Assert.AreEqual(new bool[] { true, false, true, false, false, true }, seats);
        }
    }
}
