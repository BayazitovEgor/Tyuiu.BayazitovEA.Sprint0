using Tyuiu.BayazitovEa.Split0.Task2.V0.Lib;
namespace Tyuiu.BayazitovEa.Split0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessagValid()   
        {
            var name = "Егор";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Егор",res);
        }
    }
}
