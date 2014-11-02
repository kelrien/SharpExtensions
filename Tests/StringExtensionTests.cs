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

        [TestMethod]
        public void Sha1TestSimple()
        {
            string clearText = "testString";
            //sha-1 hash of "testString"
            string hash = "956265657d0b637ef65b9b59f9f858eecf55ed6a";
            Assert.AreEqual(clearText.GetSHA1String(), hash);
        }

        [TestMethod]
        public void MD5TestSimple()
        {
            string clearText = "testString";
            //md5 hash of "testString"
            string hash = "536788f4dbdffeecfbb8f350a941eea3";
            Assert.AreEqual(clearText.GetMD5String(), hash);
        }
    }
}
