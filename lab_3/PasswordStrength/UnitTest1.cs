using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordStrength;

namespace PasswordStrengthTest
{
    [TestClass]
    public class PasswordStrengthTests
    {
        [TestMethod]
        public void IsValidPasswordTest_CorrectInput_True()
        {
            string normalInput = "4rfghjuyg";
            bool answ = Program.IsPasswordValid(normalInput);
            Assert.AreEqual(true, answ);
        }

        [TestMethod]
        public void IsValidPasswordTest_IncorrectInput_False()
        {
            string unnormalInput = "4rfgh^^juyg";
            bool answ = Program.IsPasswordValid(unnormalInput);
            Assert.AreEqual(false, answ);
        }

        [TestMethod]
        public void CountArgumentsTest_MoreThenOneArgument_false()
        {
            string[] moreArguments = new string[2] { "qwertyu678", "7ghgnjh76" };
            bool answ;
            answ = Program.CountArguments(moreArguments);
            Assert.AreEqual(false, answ);
        }

        [TestMethod]
        public void CountArgumentsTest_CorrectCountOfArguments_true()
        {
            string[] NormalArguments = new string[1] { "ghsfsghfghsdf" };
            bool answ;
            answ = Program.CountArguments(NormalArguments);
            Assert.AreEqual(true, answ);
        }

        [TestMethod]
        public void IsPasswordNotEmptyTest_NotEmptyInput_true()
        {
            string CorrectInput = "khfdkjshfsdhf";
            bool answ;
            answ = Program.IsPasswordNotEmpty(CorrectInput);
            Assert.AreEqual(true, answ);
        }

        [TestMethod]
        public void IsPasswordNotEmptyTest_EmptyInput_false()
        {
            string IncorrectInput = "";
            bool answ;
            answ = Program.IsPasswordNotEmpty(IncorrectInput);
            Assert.AreEqual(false, answ);
        }

        [TestMethod]
        public void SecondStepTest_3SymbolsInput_12expexted()
        {
            string Password = "abc";
            int answ;
            answ = Program.SecondStep(Password);
            Assert.AreEqual(12, answ);
        }

        [TestMethod]
        public void ThirdStepTest_2DigitsInput_8expected()
        {
            string Password = "fbdsfdsbfbh45";
            int answ;
            answ = Program.ThirdStep(Password);
            Assert.AreEqual(8, answ);
        }

        [TestMethod]
        public void ForthStepTest_5SymbolsInputAnd3Uppercased_4expected()
        {
            string Password = "bcABD";
            int answ;
            answ = Program.ForthStep(Password);
            Assert.AreEqual(4, answ);
        }

        [TestMethod]
        public void FifthStepTest_5SymbolsAnd2Lowercased_6expected()
        {
            string Password = "bcABD";
            int answ;
            answ = Program.FifthStep(Password);
            Assert.AreEqual(6, answ);
        }

        [TestMethod]
        public void IsOnlyLettersTest_OnlyLettersInput_true()
        {
            string Password = "sdfghjkllkjbvdhsdfh";
            bool answ;
            answ = Program.IsOnlyLetters(Password);
            Assert.AreEqual(true, answ);
        }

        [TestMethod]
        public void IsOnlyLettersTest_NotOnlyLettersInput_false()
        {
            string Password = "sdfghjk456789llkjbvdhsdfh";
            bool answ;
            answ = Program.IsOnlyLetters(Password);
            Assert.AreEqual(false, answ);
        }

        [TestMethod]
        public void IsOnlyDigitsTest_OnlyDigitsInput_true()
        {
            string Password = "1234";
            bool answ;
            answ = Program.IsOnlyDigits(Password);
            Assert.AreEqual(true, answ);
        }

        public void IsOnlyDigitsTest_NotOnlyDigitsInput_flase()
        {
            string Password = "234hdhjfsfsd";
            bool answ;
            answ = Program.IsOnlyDigits(Password);
            Assert.AreEqual(false, answ);
        }

        [TestMethod]
        public void SixthAndSeventhTest_6SymbolsAndOnlyLettersInput_6expected()
        {
            string Password = "fghjfd";
            int answ;
            answ = Program.SixthAndSeventhStep(Password);
            Assert.AreEqual(6, answ);
        }

        [TestMethod]
        public void SixthAndSeventhTest_5SymbolsAndOnlyDigitsInput_5expected()
        {
            string Password = "00000";
            int answ;
            answ = Program.SixthAndSeventhStep(Password);
            Assert.AreEqual(5, answ);
        }

        [TestMethod]
        public void SixthAndSeventhTest_NotOnlyLettersOrDigitsInput_0expected()
        {
            string Password = "fgh5q365161653165jfd";
            int answ;
            answ = Program.SixthAndSeventhStep(Password);
            Assert.AreEqual(0, answ);
        }

        [TestMethod]
        public void EighthStepTest_InputWithoutRepetitions_0expected()
        {
            string Password = "qwertyu";
            int answ;
            answ = Program.EighthStep(Password);
            Assert.AreEqual(0, answ);
        }

        [TestMethod]
        public void EighthStepTest_InputWith9Repetitions_9expected()
        {
            string Password = "qqqqwwwww";
            int answ;
            answ = Program.EighthStep(Password);
            Assert.AreEqual(9, answ);
        }

        [TestMethod]
        public void CalculatePasswordStrengthTest_QWerty1Input_48expected()
        {
            string Password = "QWerty1";
            int answ;
            answ = Program.CalculatePasswordStrength(Password);
            Assert.AreEqual(48, answ);
        }
    }
}
