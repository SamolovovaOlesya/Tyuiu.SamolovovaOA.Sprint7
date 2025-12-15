using Tyuiu.SamolovovaOA.Sprint7.Project.V5.Lib;
namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        private DataService GetService() => new DataService();

        private List<DataService.Product> GetDemoData() => new()
        {
            new DataService.Product 
            {
                ProductCode = "P1",
                ProductName = "Сахар",
                Quantity = 10,
                UnitPrice = 100
            },
            new DataService.Product
            {
                ProductCode = "P2",
                ProductName = "Мука",
                Quantity = 5,
                UnitPrice = 80
            },
            new DataService.Product
            {
                ProductCode = "P3",
                ProductName = "Соль",
                Quantity = 20,
                UnitPrice = 20
            }
        };

        [TestMethod]
        public void Search_ShouldFindByName()
        {
            var ds = GetService();
            var data = GetDemoData();

            var result = ds.Search(data, "сах");

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("P1", result[0].ProductCode);
        }

        [TestMethod]
        public void FilterByMinQuantity_ShouldReturnTwo()
        {
            var ds = GetService();
            var data = GetDemoData();

            var result = ds.FilterByMinQuantity(data, 10);

            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void SortByTotalValueDesc_ShouldReturnMaxFirst()
        {
            var ds = GetService();
            var data = GetDemoData();

            var result = ds.SortByTotalValueDesc(data);

            Assert.AreEqual("P1", result[0].ProductCode); // 1000
        }

        [TestMethod]
        public void CalculateStatistics_ShouldBeCorrect()
        {
            var ds = GetService();
            var data = GetDemoData();

            var stats = ds.CalculateStatistics(data);

            Assert.AreEqual(3, stats.Count);
            Assert.AreEqual(35, stats.QtySum);
            Assert.AreEqual(1800m, stats.ValueSum);
        }
    }
}
