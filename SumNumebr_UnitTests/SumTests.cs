using SumNumber_API;

namespace SumNumebr_UnitTests
{
    [TestClass]
    public class SumTests
    {
        [TestMethod]
        public void SumCorrect()
        {
            var num = new Numbers();
            var result = num.Sum(1, 3);

            //Assert
            Assert.AreEqual(result, 4);

        }
        [TestMethod]
        public void SumWrong()
        {
            var num = new Numbers();
            var result = num.Sum(1, 3);

            //Assert
            Assert.IsFalse(result != 4);

        }
    }
}