using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonalProjectLab;

namespace PersonalProjectLabTests
{
    [TestClass]
    public class CropSprayingTests
    {
        [TestMethod]
        public void CropSpraying_CalculateCropDusting()
        {
            //arrange
            CropSpraying spray = new CropSpraying();

            //act
            int spraying = spray.CalculateCropDustingPrice(15, 2000, 11);

            //asserting
            Assert.AreEqual(330000, spraying);
        }



        [TestMethod]
        public void CropSpraying_CalculateGroundSpraying()
        {
            //arrange
            CropSpraying spray = new CropSpraying();

            //act
            int gspraying = spray.CalculateGroundSprayingPrice(8, 2000, 11);

            //asserting
            Assert.AreEqual(176000, gspraying);
        }

    }
    
}
