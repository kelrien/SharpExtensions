using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpExtensions;

namespace Tests
{
    [TestClass]
    public class CollectionExtensionTests
    {

        [TestMethod]
        public void GetTestSimple()
        {
            //SetupDict
            Dictionary<object, object> testDict = new Dictionary<object, object>();
            testDict.Add("1", 1);
            testDict.Add("2", 2);
            testDict.Add("4", 4);

            Assert.AreEqual(testDict.Get("1",0),1);
            Assert.AreEqual(testDict.Get("2", 0), 2);
            Assert.AreEqual(testDict.Get("3", 0), 0);
            Assert.AreNotEqual(testDict.Get("3", 0), 3);
            Assert.AreEqual(testDict.Get("4", 0), 4);
        }
    }
}
