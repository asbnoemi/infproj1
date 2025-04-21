using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _3.csapt_projektTests1.backend
{
    [TestClass]
    public class appfunctionTests
    {
        [TestMethod]
        public void Victori()
        {

            int maxpoint = 5;
            int maxfault = 3;
            int actualpoint = 5;
            int actualfauli = 1;
            int result = _3.csapt_projekt.backend.appfunction.Victori(maxpoint, maxfault, actualpoint, actualfauli);
            Assert.AreEqual(1, result); // 1=nyert
        }
    }
    
}
