using CSharpier.Tests.TestFileTests;
using NUnit.Framework;

namespace CSharpier.Tests.TestFiles
{
    public class UnaryPlusExpressionTests : BaseTest
    {
        [Test]
        public void UnaryPlusExpressions()
        {
            this.RunTest("UnaryPlusExpression", "UnaryPlusExpressions");
        }
    }
}
