using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianPeasantMultiplication;

namespace RussianPeasantMultiplicationTests
{
    [TestClass]
    public class RussianPeasantMultiplicatiorTests
    {
        [TestMethod]
        [DataRow(47, 42, 1974)]
        [DataRow(13, 238, 3094)]
        public void Mul_Values_Result(int left, int right, int expectedResult)
        {
            #region ARRANGE

            #endregion

            #region ACT

            int result = RussianPeasantMultiplicator.Mul(left, right);

            #endregion

            #region ASSERT

            Assert.AreEqual(expectedResult, result);

            #endregion
        }
    }
}
