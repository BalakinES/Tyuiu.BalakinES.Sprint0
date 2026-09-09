using Tyuiu.BalakinES.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BalakinES.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Егор";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Егор", res);
        }
    }
}
