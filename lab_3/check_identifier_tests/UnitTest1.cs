using Microsoft.VisualStudio.TestTools.UnitTesting;
using check_identifier;

namespace check_identifier_tests
{
    [TestClass]
    public class check_identifier_tests
    {
        [TestMethod]
        public void numberInBegging_numberInStartOfInput_renutrErr()
        {
            string[] number_first = new string[1] { "4qwerty" };
            int min;
            min = Program.Main(number_first);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void incorrectSymbol_unexpectedSymbolInInput_returnErr()
        {
            string[] incorrect_symbol = new string[1] { "werty^tt" };
            int min;
            min = Program.Main(incorrect_symbol);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void normalWork_correctInput_return0()
        {
            string[] normal = new string[1] { "qwerty567" };
            int min;
            min = Program.Main(normal);
            Assert.AreEqual(0, min);
        }
        [TestMethod]
        public void incorrectCountArguments_moreThenOneArgument_returnErr()
        {
            string[] more_arguments = new string[2] { "qwertyu678", "7ghgnjh76" };
            int min;
            min = Program.Main(more_arguments);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void incorrectCountArguments_lessThenOneArgument_returnErr()
        {
            string[] less_arguments = new string[0] { };
            int min;
            min = Program.Main(less_arguments);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void emptyString_emptyInput_returnErr()
        {
            string[] empty_string = new string[1] { "" };
            int min;
            min = Program.Main(empty_string);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void checkLetter_correctInput_return0()
        {
            char letter = 'a';
            bool min;
            min = Program.is_letter(letter);
            Assert.AreEqual(true, min);
        }
        [TestMethod]
        public void checkLetter_incorrectInput_returnErr()
        {
            char number = '1';
            bool min;
            min = Program.is_letter(number);
            Assert.AreEqual(false, min);
        }
        [TestMethod]
        public void checkDigitr_correctInput_return0()
        {
            char number = '1';
            bool min;
            min = Program.is_digit(number);
            Assert.AreEqual(true, min);
        }
        [TestMethod]
        public void checkDigitr_incorrectInput_returnErr()
        {
            char letter = 'a';
            bool min;
            min = Program.is_digit(letter);
            Assert.AreEqual(false, min);
        }
    }
}
