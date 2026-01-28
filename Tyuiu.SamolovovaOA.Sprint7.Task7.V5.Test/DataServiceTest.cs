using System.Text;
using Tyuiu.SamolovovaOA.Sprint7.Task7.V5.Lib;
namespace Tyuiu.SamolovovaOA.Sprint7.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        //Загрузка CSV
        public void LoadFromCsv_ShouldReturnData()
        {
            DataService ds = new DataService();

            string path = "test.csv";

            File.WriteAllLines(path, new[]{"Code;Name;Quantity;Price;Note","A1;Test;2;50;Note"}, Encoding.UTF8);

            string[,] data = ds.LoadFromCsv(path);

            Assert.AreEqual(1, data.GetLength(0));
            Assert.AreEqual("A1", data[0, 0]);

            File.Delete(path);
        }

        //Сохранение CSV
        [TestMethod]
        public void SaveToCsv_ShouldCreateFile()
        {
            DataService ds = new DataService();

            string path = "save_test.csv";

            string[,] data ={{ "A1", "Test", "1", "100", "Note", "100" }};
            ds.SaveToCsv(path, data);

            Assert.IsTrue(File.Exists(path));

            File.Delete(path);
        }

        //Поиск
        [TestMethod]
        public void Search_ShouldFindSugar()
        {
            DataService ds = new DataService();

            string[,] data =
            {
                { "P1", "Сахар", "10", "100", "Белый", "1000" },
                { "P2", "Мука",  "5",  "80",  "Пшеничная", "400" },
                { "P3", "Соль",  "20", "20",  "Каменная", "400" }
            };

            string[,] result = ds.Search(data, "сах");

            Assert.AreEqual(1, result.GetLength(0));
            Assert.AreEqual("Сахар", result[0, 1]);
        }

        //Сортировка
        [TestMethod]
        public void SortData_ByPriceAsc_ShouldReturnCheapestFirst()
        {
            DataService ds = new DataService();

            string[,] data =
            {
                { "A1", "X", "1", "100", "", "100" },
                { "A2", "Y", "1", "50",  "", "50"  },
                { "A3", "Z", "1", "200", "", "200" }
            };

            string[,] result = ds.SortData(data, 3, true, true);

            Assert.AreEqual("A2", result[0, 0]); 
        }

        //Статистика
        [TestMethod]
        public void GetValueStatistics_ShouldReturnCorrectValues()
        {
            DataService ds = new DataService();

            string[,] data =
            {
                { "", "", "", "", "", "100" },
                { "", "", "", "", "", "200" },
                { "", "", "", "", "", "300" }
            };

            var stats = ds.GetValueStatistics(data);

            Assert.AreEqual(100, stats.Min);
            Assert.AreEqual(300, stats.Max);
            Assert.AreEqual(200, stats.Avg);
            Assert.AreEqual(600, stats.Sum);
        }

        //Фильтр (в наличии)
        [TestMethod]
        public void FilterInStock_ShouldReturnOnlyPositiveQuantity()
        {
            DataService ds = new DataService();

            string[,] data =
            {
                { "P1", "Сахар", "10", "100", "Белый", "1000" },
                { "P2", "Мука",  "0",  "80",  "Пшеничная", "0" },
                { "P3", "Соль",  "-5", "20",  "Каменная", "-100" }
            };

            string[,] result = ds.FilterInStock(data);

            Assert.AreEqual(1, result.GetLength(0));
            Assert.AreEqual("Сахар", result[0, 1]);
        }
    }
}