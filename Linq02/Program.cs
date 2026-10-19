using LINQ.DataSources;
using LINQ.Models;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            //var sortedList = Source.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var list in sortedList)
            //{
            //    Console.WriteLine(list);
            //}
            #endregion

            #region Question02
            //var BeveragesOrderedByStock = Source.ProductList.Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);

            //  foreach (var product in BeveragesOrderedByStock)
            //{
            //    Console.WriteLine($"Name: {product.ProductName} , Stock : {product.UnitsInStock}");
            //}


            #endregion

            #region Question03
            //var query = from c in Source.CustomerList
            //            from o in c.Orders
            //            where o.OrderDate >= new DateTime(1997, 1, 1)
            //            select new
            //            {
            //                c.CustomerID,
            //                o.OrderDate
            //            };

            //foreach (var item in query)
            //    Console.WriteLine($"{item.CustomerID} - {item.OrderDate}");

            #endregion

            #region Question04
            //var productsIndexed = Source.ProductList.Select((p, i) => $"{i}. {p.ProductName}");
            //foreach (var product in productsIndexed)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Question05
            //string [] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // var result = Arr.OrderBy(a => a.Length)
            //                 .ThenBy(a => a, StringComparer.OrdinalIgnoreCase);

            // foreach (var word in result)
            // {
            //     Console.WriteLine(word);
            // }

            #endregion

            #region Question06
            //string[] Arr = { "aPPlE", "AiAcUs", "bRaNcH", "BlUeBeRrY", "CiOvEr", "cHeRry" };

            //var result = Arr.Where(a => a[1] == 'i').Reverse();

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #region Question07
            //var threeExpensiveProducts = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var product in threeExpensiveProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question08
            //var result = Source.ProductList.Skip(5)
            //                               .Take(5);

            //foreach (var p in result)
            //    Console.WriteLine(p.ProductName);
            #endregion

            #region Question09
            //var cheapSortedProducts = Source.ProductList.Where(p => p.UnitPrice < 25)
            //                                            .OrderBy(p => p.UnitPrice);

            //foreach(var product in cheapSortedProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question10

            //var IsAllSeafoodInStock = Source.ProductList.Where(p => p.Category == "Seafood")
            //                                                  .All(p => p.UnitsInStock>0);

            //Console.WriteLine($"Is All Seafood InStock? : {IsAllSeafoodInStock}");
            #endregion

            #region Question11
            //int[] ids = { 3, 9, 13, 18 };

            //bool result = ids.Contains(9);

            //Console.WriteLine($"Does IDs list contain 9? : {result}");

            #endregion

            #region Question12

            //var productsGroupedByCategory = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var group in productsGroupedByCategory)
            //    Console.WriteLine($"{group.Key} - {group.Count()}");
            #endregion

            #region Question13
            //var productsGroupedByCategory = Source.ProductList.GroupBy(p => p.Category);

            //foreach(var group in productsGroupedByCategory)
            //{
            //    Console.WriteLine(group.Key);
            //    Console.WriteLine();
            //    foreach(var product in group )
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }
            //    Console.WriteLine("----------------------------------------------------");
            //}
            #endregion

            #region Question14
            //var categories = Source.ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);
            //foreach(var category in categories)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //}
            #endregion

            #region Question15
            //var result = from c in Source.CustomerList 
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.SelectMany(c => c.Orders)
            //               .Sum(o => o.Total)
            //             };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(
            //        $"{item.Country} - {item.Count} - {item.TotalOrderValue}");
            //}
            #endregion

            #region Question16
            //var totalInsTock = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine($"Total Units In Stock: {totalInsTock}");
            #endregion

            #region Question17
            //var cheapest = Source.ProductList.Min(p => p.UnitPrice);
            //var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest: {cheapest}");
            //Console.WriteLine($"Most Expensive: {mostExpensive}");
            #endregion

            #region Question18

            //var result = Source.ProductList.DistinctBy(p => p.Category);
            //foreach(var p in result)
            //{
            //    Console.WriteLine(p.Category);
            //}
            #endregion

            #region Question19
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question20
            //string[] list1 = { "Germany", "France", "UK", "Spain" }; 
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question21
            //Dictionary<int, Product> products = Source.ProductList.ToDictionary(p => p.ProductID);

            //var result = products[18];

            //Console.WriteLine($"{result.ProductName} - {result.UnitPrice}");
            #endregion

            #region Question22
            //var result = Source.ProductList.First(p => p.UnitPrice > 50);
            //Console.WriteLine(result);
            #endregion

            #region Question23
            //var result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result);

            #endregion

            #region Question24
            //var result = Enumerable.Range(1, 10).Select(n => 7 * n);

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Question25
            //var result = Enumerable.Range(1,30).Where(n => n%2==0);

            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

        }
    }
}
