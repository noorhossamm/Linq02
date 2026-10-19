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

        }
    }
}
