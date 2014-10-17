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

        [TestMethod]
        public void IsValidEmailTestSimple()
        {
            string valid = "peter@googlemail.com";
            string invalid = "peter@google";
            Assert.IsTrue(valid.IsValidEmailAddress());
            Assert.IsFalse(invalid.IsValidEmailAddress());
        }

        [TestMethod]
        public void IsValidUrlTestSimple()
        {
            string valid = "https://www.valid-url.com";
            string invalid = "isnotavalidurl.com";
            Assert.IsTrue(valid.IsValidUrl());
            Assert.IsFalse(invalid.IsValidUrl());
        }

        [TestMethod]
        public void FormatTestSimple()
        {
            string toFormat = "{0}, two, {1}, {2}";
            object[] parameters = {"one",3,"4"};
            Assert.AreEqual(toFormat.Format(parameters), String.Format(toFormat, parameters));
        }
    }
}
