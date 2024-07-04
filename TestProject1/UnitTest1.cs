using Sepselev_01_07;
using Sepselev_01_07.Vrednosty;
using NUnit.Framework;
namespace TestProject1
{
    public class Tests
    {
        private QalityObject _QO;
        private Vrednosty _VR;
        [SetUp]
        public void Setup()
        {
            _QO = new QalityObject("Q", 8, 20.0);
            _VR = new Vrednosty("V", 6, 15.0, "true");
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Q",_QO.Type);
            Assert.AreEqual(8, _QO.Kolvo);
            Assert.AreEqual(20, _QO.Diametr);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("V", _VR.Type);
            Assert.AreEqual(6, _VR.Kolvo);
            Assert.AreEqual(15, _VR.Diametr);
            Assert.AreEqual("true", _VR.TF);
        }
        [Test]
        public void Test3()
        {
            double expected = 20.0 / 8;
            Assert.AreEqual(expected, _QO.CalculateInfo());
        }
   
        
    }
}