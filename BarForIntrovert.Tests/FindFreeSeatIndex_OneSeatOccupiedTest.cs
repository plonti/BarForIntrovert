using NUnit.Framework;



namespace BarForIntrovert.Tests {
    [TestFixture]
    class FindFreeSeatIndex_OneSeatOccupiedTest {
        [Test]
        public void FiveEmptySeatsTest() {
            bool[] seats = new bool[] {
                false, false, false, false, false
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(0, spareIndex, "index");
            Assert.AreEqual(5, spareLength, "length");
        }

        [Test]
        public void FiveSeatsFirstOccupiedTest() {
            bool[] seats = new bool[] {
                true, false, false, false, false
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(1, spareIndex, "index");
            Assert.AreEqual(4, spareLength, "length");
        }

        [Test]
        public void FiveSeatsSecondOccupiedTest() {
            bool[] seats = new bool[] {
                false, true, false, false, false
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(2, spareIndex, "index");
            Assert.AreEqual(3, spareLength, "length");
        }

        [Test]
        public void FiveSeatsThirdOccupiedTest() {
            bool[] seats = new bool[] {
                false, false, true, false, false
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(3, spareIndex, "index");
            Assert.AreEqual(2, spareLength, "length");
        }

        [Test]
        public void FiveSeatsFourthOccupiedTest() {
            bool[] seats = new bool[] {
                false, false, false, true, false
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(0, spareIndex, "index");
            Assert.AreEqual(3, spareLength, "length");
        }

        [Test]
        public void FiveSeatsFifthOccupiedTest() {
            bool[] seats = new bool[] {
                false, false, false, false, true
            };
            (int spareIndex, int spareLength) = IntrovertActions.FindLongestSpareSeats(seats);
            Assert.AreEqual(0, spareIndex, "index");
            Assert.AreEqual(4, spareLength, "length");
        }
    }
}


