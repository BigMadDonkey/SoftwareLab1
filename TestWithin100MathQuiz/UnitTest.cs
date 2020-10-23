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
            Assert.AreEqual(true, 1 < multiplyLeft & multiplyLeft < 30);
            Assert.AreEqual(true, 1 < multiplyRight & multiplyRight < 20);
            Assert.AreEqual(true, divideLeft % divideRight == 0 & divideLeft/divideRight < 30);
            Assert.AreEqual(true, 1 < divideRight & divideRight < 20);
        }

        [TestMethod]
        public void TestMethodCheck()
        {
            Assert.AreEqual((true, 3), add.check(1, 2, 3));
            Assert.AreEqual((false, 3), add.check(1, 2, 4));

            Assert.AreEqual((true, 0), minus.check(2, 2, 0));
            Assert.AreEqual((false, 0), minus.check(2, 2, 23));

            Assert.AreEqual((true, 6), multiply.check(2, 3, 6));
            Assert.AreEqual((false, 6), multiply.check(2, 3, 123));

            Assert.AreEqual((true, 50), divide.check(100, 2, 50));
            Assert.AreEqual((false, 25), divide.check(50, 2, 1));
        }
    }
}