using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaesarCipher;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void DecryptTest()
        {
            string text = "defghIJ"; 
            int shift = 3;
            string expected = "abcdeFG";

            string result = CaesarCipher.Caesar.Decrypt(shift, text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void DecryptTest2()
        {
            string text = "Muuj suxtotm, ###";
            int shift = 6;
            string expected = "Good morning, ###";

            string result = CaesarCipher.Caesar.Decrypt(shift, text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EncryptTest()
        {
            string text = "abcdeFG";
            int shift = 3;
            string expected = "defghIJ";

            string result = CaesarCipher.Caesar.Encrypt(shift, text);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void EncryptTest2()
        {
            string text = "This is Unit test!!";
            int shift = 2;
            string expected = "Vjku ku Wpkv vguv!!";

            string result = CaesarCipher.Caesar.Encrypt(shift, text);
            Assert.AreEqual(expected, result);
        }
    }
}