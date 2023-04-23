namespace calculator_tests
{
    public class BasicOperations
    {
        SuperCalcLib.BasicOperations _op;
        [SetUp]
        public void Setup() => _op = new SuperCalcLib.BasicOperations();
        

        /*[Test]
        public void Summ_A_And_B_Equals_Result_Test()
        {
            var summ = _op.Summ(5, 5);
            Assert.That(summ, Is.EqualTo(10));
        }*/

        [Test]
        public void Raznost_A_And_B_Equals_Result_Test()
        {
            var raznost = _op.Razmost(5, 5);
            Assert.That(raznost, Is.EqualTo(0));
        }

        [TestCase(5,5, 10)]
        [TestCase(1, 1, 2)]
        [TestCase(-1, 0,-1)]
        [TestCase(-1, 1, 0)]
        public void Summ_A_And_B_Equals_Result_Test(int a,int b, int result)
        {
            var summ = _op.Summ(a, b);
            Assert.That(summ, Is.EqualTo(result));
        }
    }
}