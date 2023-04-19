using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExamApp;

namespace ExamUnitTests
{
    [TestClass]
    public class ValidationUnitTests
    {
        [TestMethod]
        public void TestAuthorValidation()
        {
            string wrongText = "Пушкин";
            string rightText = "Пушкин Александр Сергеевич";

            Assert.IsFalse(Validator.ValidateAuthor(wrongText));
            Assert.IsTrue(Validator.ValidateAuthor(rightText));
        }

        [TestMethod]
        public void TestNameValidation()
        {
            string wrongText = "1984";
            string rightText = "О дивный новый мир";

            Assert.IsFalse(Validator.ValidateName(wrongText));
            Assert.IsTrue(Validator.ValidateName(rightText));
        }

        [TestMethod]
        public void TestYearValidation()
        {
            string wrongText = "-12abcd";
            string rightText = "1922";

            Assert.IsFalse(Validator.ValidateYear(wrongText));
            Assert.IsTrue(Validator.ValidateYear(rightText));
        }
    }
}
