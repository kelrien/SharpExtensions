using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpExtensions;

namespace Tests
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void ReplaceFirstTestSimple()
        {
            string example = "Hello World!";
            string target = "Ho World!";
            Assert.AreEqual(example.ReplaceFirst("ell", ""),target);
        }
    }
}
