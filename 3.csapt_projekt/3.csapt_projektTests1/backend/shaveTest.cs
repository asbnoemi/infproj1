using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3.csapt_projektTests1.backend
{
    [TestClass]
    public class shaveTest
    {
        
        [TestMethod]
        public void ShaveFile()
        {
            var res = _3.csapt_projekt.backend.Shave.Me.ShaveFile();
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void loadTest()
        {
        }
        [TestMethod]
        public void roppscoreTest()
        {
            //var res = _3.csapt_projekt.backend.Shave.Me.roppscore();
           // Assert.IsTrue(res);

        }
        


    }
}
