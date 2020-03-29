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
            string[] wrong1 = new string[1] { "4qwerty" };
            int min;
            min = Program.Main(wrong1);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void incorrectSymbol_unexpectedSymbolInInput_returnErr()
        {
            string[] wrong1 = new string[1] { "werty^tt" };
            int min;
            min = Program.Main(wrong1);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void normalWork_correctInput_return0()
        {
            string[] wrong1 = new string[1] { "qwerty567" };
            int min;
            min = Program.Main(wrong1);
            Assert.AreEqual(0, min);
        }
        [TestMethod]
        public void incorrectCountArguments_moreThenOneArgument_returnErr()
        {
            string[] wrong1 = new string[2] { "qwertyu678", "7ghgnjh76" };
            int min;
            min = Program.Main(wrong1);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void incorrectCountArguments_lessThenOneArgument_returnErr()
        {
            string[] wrong1 = new string[0] { };
            int min;
            min = Program.Main(wrong1);
            Assert.AreEqual(1, min);
        }
        [TestMethod]
        public void emptyString_emptyInput_returnErr()
        {
            string[] wrong1 = new string[1] { "" };
            int min;
            min = Program.Main(wrong1);
            Assert.AreEqual(1, min);
        }
    }
}
