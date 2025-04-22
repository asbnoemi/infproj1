using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3.csapt_projektTests1.backend
{
    [TestClass]
    public class shaveTest
    {
        [TestMethod]
        partial void ShaveTest()
        {
            var res = _3.csapt_projekt.backend.Shave.Me;
            Assert.IsNotNull(res);
        }
        [TestMethod]
        partial void ShaveFileTest()
        {
            var res = _3.csapt_projekt.backend.Shave.Me.ShaveFile();
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void ShaveFile()
        {
            var res = _3.csapt_projekt.backend.Shave.Me.ShaveFile();
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void loadTest()
        {
            var res = _3.csapt_projekt.backend.Shave.Me.load();
            Assert.IsNotNull(res);
        }
        [TestMethod]
        public void roppscoreTest()
        {
            var res = _3.csapt_projekt.backend.Shave.Me.roppscore();
            Assert.IsNotNull(res);
            Assert.AreEqual(res.Length, 3);
            Assert.IsTrue(res[0].scoreLs[0].Score >= res[1].scoreLs[0].Score);
            Assert.IsTrue(res[1].scoreLs[0].Score >= res[2].scoreLs[0].Score);
        }
        [TestMethod]


    }
}
