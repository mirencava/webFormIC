using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{


    [TestClass]
    public class UnitTest1
    {
        /*
        private readonly Default _console;
        public UnitTest1()
        {
            _console = new Default();
        }
        */
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void TestButton1_Click()
        {
        }
    }
}
