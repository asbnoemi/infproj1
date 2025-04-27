using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3.csapt_projekt.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.csapt_projekt.backend.Tests
{
    [TestClass()]
    public class QuestReadTests
    {
        [TestMethod()]
        public void QuestReadTest()
        {
            var res = QuestRead.MeQ;
            Assert.IsNotNull(res);
        }

        [TestMethod()]
        public void loadTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void QestverificationTest()
        {
            QuestRead.MeQ.load();
            var res = QuestRead.MeQ.Qestverification("A", 1, 0, 0);
            Assert.IsTrue(res.Item1);
            Assert.AreEqual(res.Item2, 1);
            Assert.AreEqual(res.Item3, 0);
        }


        [TestMethod()]
        public void randQestGenTest()
        {
            
            



        }
    }
}