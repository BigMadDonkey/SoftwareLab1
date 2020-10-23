using System.Reflection.Emit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Within100MathQuiz;

namespace TestWithin100MathQuiz
{
    [TestClass]
    public class UnitTestOp
    {
        Op add = Op.create_Op(0);
        Op minus = Op.create_Op(1);
        Op multiply = Op.create_Op(2);
        Op divide = Op.create_Op(3);
        [TestMethod]
        public void TestMethodGenerate()
        {

            add.generate_Data(out int addLeft, out int addRight);
            minus.generate_Data(out int minusLeft, out int minusRight);
            multiply.generate_Data(out int multiplyLeft, out int multiplyRight);
            divide.generate_Data(out int divideLeft, out int divideRight);
            //检查生成数据的合法性
            Assert.AreEqual(true, 1 < addLeft & addLeft < 50);
            Assert.AreEqual(true, 1 < addRight & addRight < 50);
            Assert.AreEqual(true, 1 < minusLeft & minusLeft < 50);
            Assert.AreEqual(true, 1 < minusRight & minusRight < 50);
            Assert.AreEqual(true, 1 < multiplyLeft & multiplyLeft < 50);
            Assert.AreEqual(true, 1 < multiplyRight & multiplyRight < 50);
            Assert.AreEqual(true, divideLeft % divideRight == 0);
            Assert.AreEqual(true, 1 < divideRight & divideRight < 50);
        }

        [TestMethod]
        public void TestMethodCheck()
        {
            Assert.AreEqual(true, add.check(1, 2, 3));
            Assert.AreEqual(false, add.check(1, 2, 4));

            Assert.AreEqual(true, minus.check(2, 2, 0));
            Assert.AreEqual(false, minus.check(2, 2, 23));

            Assert.AreEqual(true, multiply.check(2, 3, 6));
            Assert.AreEqual(false, multiply.check(2, 3, 123));

            Assert.AreEqual(true, divide.check(100, 2, 50));
            Assert.AreEqual(false, divide.check(50, 2, 1));
        }
    }
}
