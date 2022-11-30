// Якубовський Владислав, РІ-11, АП, unit-тест до ЛР 8.2
namespace AP_Lab_08_2_UT
{
    [TestClass]
    public class Lab_08_2_UT
    {
        [TestMethod]
        public void TestChange()
        {
            string stringToTest = "a(abcd)b(erer)c(fff)d()", changedString = ChangeString(stringToTest, out _);

            Assert.AreEqual("abcd", changedString);
        }
    }
}