using System.Text;
using System.Globalization;

namespace Tyuiu.SamolovovaOA.Sprint7.Task7.V5.Lib
{
    public class DataService
    {
        // Загрузка из CSV
        public string[,] LoadFromCsv(string path)
        {
            if (!File.Exists(path)) return new string[0, 0];

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            int rows = lines.Length - 1;
            int cols = 6;

            string[,] data = new string[rows, cols];

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');

                data[i - 1, 0] = parts[0]; 
                data[i - 1, 1] = parts[1]; 
                data[i - 1, 2] = parts[2]; 
                data[i - 1, 3] = parts[3];
                data[i - 1, 4] = parts[4]; 

                int qty = int.Parse(parts[2]);
                double price = double.Parse(parts[3], CultureInfo.InvariantCulture);
                data[i - 1, 5] = (qty * price).ToString();
            }

            return data;
        }

        // Сохранение CSV
        public void SaveToCsv(string path, string[,] data)
        {
            int rows = data.GetLength(0);

            string[] lines = new string[rows + 1];
            lines[0] = "Code;Name;Quantity;Price;Note";

            for (int i = 0; i < rows; i++)
            {
                lines[i + 1] =
                    data[i, 0] + ";" +
                    data[i, 1] + ";" +
                    data[i, 2] + ";" +
                    data[i, 3] + ";" +
                    data[i, 4];
            }

            File.WriteAllLines(path, lines, new UTF8Encoding(true));
        }

        // Поиск по названию
        public string[,] Search(string[,] data, string text)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            text = text.ToLower();

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 0].ToLower().Contains(text) || data[i, 1].ToLower().Contains(text))     
                {
                    count++;
                }
            }

            string[,] result = new string[count, cols];

            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                if (data[i, 0].ToLower().Contains(text) || data[i, 1].ToLower().Contains(text))
                {
                    for (int j = 0; j < cols; j++)
                    {
                        result[k, j] = data[i, j];
                    }
                    k++;
                }
            }
             
            return result;
        }

        // Сортировка
        public string[,] SortData(string[,] data, int col, bool asc, bool isNumeric)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    bool needSwap;

                    if (isNumeric)
                    {
                        double a = double.TryParse(data[i, col], out var da) ? da : 0;
                        double b = double.TryParse(data[j, col], out var db) ? db : 0;
                        needSwap = asc ? a > b : a < b;
                    }
                    else
                    {
                        int cmp = string.Compare(data[i, col],data[j, col],StringComparison.OrdinalIgnoreCase);
                        needSwap = asc ? cmp > 0 : cmp < 0;
                    }

                    if (needSwap)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            string tmp = data[i, c];
                            data[i, c] = data[j, c];
                            data[j, c] = tmp;
                        }
                    }
                }
            }

            return data;
        }

        // Статистика
        public (double Min, double Max, double Avg, double Sum) GetValueStatistics(string[,] data)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            int count = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (double.TryParse(data[i, 5], out double value))
                {
                    if (value < min) min = value;
                    if (value > max) max = value;
                    sum += value;
                    count++;
                }
            }

            if (count == 0)
                return (0, 0, 0, 0);

            double avg = sum / count;
            return (min, max, avg, sum);
        }

        // Фильтр (в наличии)
        public string[,] FilterInStock(string[,] data)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                if (int.TryParse(data[i, 2], out int qty) && qty > 0)
                    count++;
            }

            string[,] result = new string[count, cols];

            int k = 0;
            for (int i = 0; i < rows; i++)
            {
                if (int.TryParse(data[i, 2], out int qty) && qty > 0)
                {
                    for (int j = 0; j < cols; j++)
                        result[k, j] = data[i, j];

                    k++;
                }
            }

            return result;
        }
    }
}

