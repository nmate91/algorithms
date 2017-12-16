using System;
using NUnit.Framework;
using PandigitalPrime;

namespace Test_PandigitalPrime
{
    public class Test_PandigitalPrime
    {
        
        [Test]
        public void Test_PrimeValidator()
        {
            Assert.True(PrimeValidator.IsPrime(3));
            Assert.False(PrimeValidator.IsPrime(14));

            Assert.True(PrimeValidator.IsPrime(19));
            Assert.False(PrimeValidator.IsPrime(58));

            Assert.True(PrimeValidator.IsPrime(59));
            Assert.False(PrimeValidator.IsPrime(264));

            Assert.True(PrimeValidator.IsPrime(263));
        }

        [Test]
        public void Test_PandigitalValidator()
        {
            Assert.True(PandigitalValidator.IsPandigital(12340));
            Assert.False(PandigitalValidator.IsPandigital(1345));

            Assert.True(PandigitalValidator.IsPandigital(76543210));
            Assert.False(PandigitalValidator.IsPandigital(58));

            Assert.True(PandigitalValidator.IsPandigital(2103));
            Assert.False(PandigitalValidator.IsPandigital(123456));

            Assert.True(PandigitalValidator.IsPandigital(6152430));
        }

        [Test]
        public void Test_DivisableByThree()
        {
            PandigitalPrimeValidator ppValidator = new PandigitalPrimeValidator();
            Assert.True(ppValidator.DivisableByThree(999999));
            Assert.False(ppValidator.DivisableByThree(88));
            Assert.True(ppValidator.DivisableByThree(12345));
        }

        [Test]
        public void Test_GetMaxPandigital()
        {
            PandigitalPrimeValidator ppValidator = new PandigitalPrimeValidator();
            Assert.AreEqual(ppValidator.GetNextMaxPandigital(473283), 43210);
        }

    }
}
