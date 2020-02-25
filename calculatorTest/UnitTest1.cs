using NUnit.Framework;
using alleeAssignment3Calculator;
using System.Windows.Forms.ButtonTester;


namespace calculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Form1 form = new Form1();
            ButtonTester button = new ButtonTester("buttonName");
        }

        [Test]
        public void Test1button1()
        {
            Assert.Pass();
        }
    }
}