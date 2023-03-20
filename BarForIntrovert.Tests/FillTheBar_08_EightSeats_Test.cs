using NUnit.Framework;

namespace BarForIntrovert.Tests {
    [TestFixture]
    class FillTheBar_08_EightSeats_Test {
        [Test]
        public void EightSeats_FirstTaken_Test() {
            var seats = new bool[] {
                true, false, false, false, false, false, false, false
            };
            Helper.FillTheBar(seats);
            var expected = new bool[] {
                true, false, false, true, false, true, false, true
            };
            Assert.AreEqual(expected, seats);
        }

        [Test]
        public void EightSeats_SecondTaken_Test() {
            var seats = new bool[] {
                false, true, false, false, false, false, false, false
            };
            Helper.FillTheBar(seats);
            var expected = new bool[] {
                false, true, false, false, true, false, false, true
            };
            Assert.AreEqual(expected, seats);
        }

        [Test]
        public void EightSeats_ThirdTaken_Test() {
            var seats = new bool[] {
                false, false, true, false, false, false, false, false
            };
            Helper.FillTheBar(seats);
            var expected = new bool[] {
                true, false, true, false, true, false, false, true
            };
            Assert.AreEqual(expected, seats);
        }

        [Test]
        public void EightSeats_ForthTaken_Test() {
            var seats = new bool[] {
                false, false, false, true, false, false, false, false
            };
            Helper.FillTheBar(seats);
            var expected = new bool[] {
                true, false, false, true, false, true, false, true
            };
            Assert.AreEqual(expected, seats);
        }

        [Test]
        public void EightSeats_FifthTaken_Test() {
            var seats = new bool[] {
                false, false, false, false, true, false, false, false
            };
            Helper.FillTheBar(seats);
            var expected = new bool[] {
                true, false, true, false, true, false, false, true
            };
            Assert.AreEqual(expected, seats);
        }

        [Test]
        public void EightSeats_SixthTaken_Test() {
            var seats = new bool[] {
                false, false, false, false, false, true, false, false
            };
            Helper.FillTheBar(seats);
            var expected = new bool[] {
                true, false, true, false, false, true, false, true
            };
            Assert.AreEqual(expected, seats);
        }

        [Test]
        public void EightSeats_SeventhTaken_Test() {
            var seats = new bool[] {
                false, false, false, false, false, false, true, false
            };
            Helper.FillTheBar(seats);
            var expected = new bool[] {
                true, false, false, true, false, false, true, false
            };
            Assert.AreEqual(expected, seats);
        }

        [Test]
        public void EightSeats_EighthTaken_Test() {
            var seats = new bool[] {
                false, false, false, false, false, false, false, true
            };
            Helper.FillTheBar(seats);
            var expected = new bool[] {
                true, false, false, true, false, true, false, true
            };
            Assert.AreEqual(expected, seats);
        }
    }
}
