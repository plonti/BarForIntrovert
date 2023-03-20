using NUnit.Framework;



namespace BarForIntrovert.Tests {
    [TestFixture]
    class FindFreeSeatIndex_TwoSeatsOccupiedTest {
        [Test]
        public void SixSeatsFirstAndThirdOccupiedTest() {
            bool[] seats = new bool[] {
                true, false, true, false, false, false
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(3, spareIndex, "index");
            Assert.AreEqual(3, spareLength, "length");
        }

        [Test]
        public void SixSeatsFirstAndFourthOccupiedTest() {
            bool[] seats = new bool[] {
                true, false, false, true, false, false
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(4, spareIndex, "index");
            Assert.AreEqual(2, spareLength, "length");
        }

        [Test]
        public void SixSeatsSecondAndSixthOccupiedTest() {
            bool[] seats = new bool[] {
                false, true, false, false, false, true
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(2, spareIndex, "index");
            Assert.AreEqual(3, spareLength, "length");
        }
    }
}


