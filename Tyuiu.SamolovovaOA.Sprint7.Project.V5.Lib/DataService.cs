using System.Globalization;

namespace Tyuiu.SamolovovaOA.Sprint7.Project.V5.Lib
{
    public class DataService
    {
        public class Product
        {
            public string ProductCode { get; set; } = "";
            public string ProductName { get; set; } = "";
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public string Notes { get; set; } = "";

            public decimal TotalValue => Quantity * UnitPrice;
        }

        //CSV 
        public List<Product> LoadFromCsv(string filePath)
        {
            var result = new List<Product>();

            if (!File.Exists(filePath))
                return result;

            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) // пропускаем заголовок
            {
                var parts = lines[i].Split(';');
                if (parts.Length < 5) continue;

                if (!int.TryParse(parts[2], out int qty)) continue;
                if (!decimal.TryParse(parts[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal price)) continue;

                result.Add(new Product
                {
                    ProductCode = parts[0],
                    ProductName = parts[1],
                    Quantity = qty,
                    UnitPrice = price,
                    Notes = parts[4]
                });
            }

            return result;
        }

        public void SaveToCsv(string filePath, List<Product> products)
        {
            var lines = new List<string>
            {
                "ProductCode;ProductName;Quantity;UnitPrice;Notes"
            };

            foreach (var p in products)
            {
                lines.Add(
                    $"{p.ProductCode};{p.ProductName};{p.Quantity};" +
                    $"{p.UnitPrice.ToString(CultureInfo.InvariantCulture)};" +
                    $"{p.Notes.Replace(";", ",")}"
                );
            }

            File.WriteAllLines(filePath, lines);
        }

        //ПОИСК
        public List<Product> Search(List<Product> products, string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return products;

            query = query.ToLower();

            return products
                .Where(p =>
                    p.ProductCode.ToLower().Contains(query) ||
                    p.ProductName.ToLower().Contains(query))
                .ToList();
        }

        //ФИЛЬТР
        public List<Product> FilterByMinQuantity(List<Product> products, int minQty)
        {
            return products.Where(p => p.Quantity >= minQty).ToList();
        }

        //СОРТИРОВКА
        public List<Product> SortByTotalValueDesc(List<Product> products)
        {
            return products.OrderByDescending(p => p.TotalValue).ToList();
        }

        //СТАТИСТИКА
        public (int Count, int QtySum, double QtyAvg, int QtyMin, int QtyMax, decimal ValueSum)
            CalculateStatistics(List<Product> products)
        {
            if (products.Count == 0)
                return (0, 0, 0, 0, 0, 0);

            return (
                products.Count,
                products.Sum(p => p.Quantity),
                products.Average(p => p.Quantity),
                products.Min(p => p.Quantity),
                products.Max(p => p.Quantity),
                products.Sum(p => p.TotalValue)
            );
        }
    }
}
