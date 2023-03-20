using NUnit.Framework;

namespace BarForIntrovert.Tests {
    [TestFixture]
    class FindOptimalChoisesTest {
        [Test]
        public void BarSizeThreeTest() {
            int[] optimalChoises = Program.FindOptimalChoices(barSize: 3);
            Assert.AreEqual(new int[] { 0, 2 }, optimalChoises);
        }

        [Test]
        public void BarSizeFourTest() {
            int[] optimalChoises = Program.FindOptimalChoices(barSize: 4);
            Assert.AreEqual(new int[] { 0, 1, 2, 3 }, optimalChoises);
        }

        [Test]
        public void BarSizeFiveTest() {
            int[] optimalChoises = Program.FindOptimalChoices(barSize: 5);
            Assert.AreEqual(new int[] { 0, 2, 4 }, optimalChoises);
        }

        [Test]
        public void BarSizeSixTest() {
            int[] optimalChoises = Program.FindOptimalChoices(barSize: 6);
            Assert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5 }, optimalChoises);
        }

        [Test]
        public void BarSizeSevenTest() {
            int[] optimalChoises = Program.FindOptimalChoices(barSize: 7);
            Assert.AreEqual(new int[] { 2, 4 }, optimalChoises);
        }

        [Test]
        public void BarSizeEightTest() {
            int[] optimalChoises = Program.FindOptimalChoices(barSize: 8);
            Assert.AreEqual(new int[] { 0, 2, 3, 4, 5, 7 }, optimalChoises);
        }

        [Test]
        public void BarSizeNineTest() {
            int[] optimalChoises = Program.FindOptimalChoices(barSize: 9);
            Assert.AreEqual(new int[] { 0, 4, 8 }, optimalChoises);
        }
    }
}
