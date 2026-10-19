using LINQ.DataSources;

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

        }
    }
}
