using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boites;

namespace TestsBoites
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesterCompteur()
        {
            Boite b1 = new Boite(10, 20, 30);
            Boite b2 = new Boite(10, 10, 10, Matières.Carton);
            Assert.AreEqual(2, Boite.Compteur);
        }

        [TestMethod]
        public void TesterVolume()
        {
            Boite b1 = new Boite(10, 20, 30);
            Assert.AreEqual(6000, b1.Volume);
        }

    }
}
