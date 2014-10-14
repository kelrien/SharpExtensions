using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpExtensions;

namespace SharpExtensions.Tests
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

        [TestMethod]
        public void ReplaceLastTestSimple()
        {
            string example = "Hello World!";
            string target = "Hello Word!";
            Assert.AreEqual(example.ReplaceLast("l", ""), target);
        }
    }
}
