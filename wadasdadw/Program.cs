using static wadasdadw.Source;
using static wadasdadw.Product;
using static wadasdadw.Customer;
using static wadasdadw.Employee;
using static wadasdadw.Order;
using static wadasdadw.Student;
namespace wadasdadw
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region Q1
            //var result = Source.ProductList.Where(c => c.Category == "Seafood");
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"product name is {product.ProductName} ");
            //    Console.WriteLine($"product price is {product.UnitPrice} ");
            //}
            #endregion

            #region Q2
            //var result = Source.ProductList.Select(p => p.ProductName);

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Q4

            //var result = Source.ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);
            //foreach(var item in result) 
            // {
            //    Console.WriteLine(item);

            // }
            #endregion

            #region Q5
            //var result = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");
            //foreach (var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion

            #region Q3
            //var result = Source.ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.ProductName} {item.UnitPrice}");
            //}

            #endregion

            #region Q6
            //var result=Source.ProductList.Select(p=> new 
            //{Name=p.ProductName,
            //Price=p.UnitPrice,
            //StockStatus= p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
            //}
            #endregion

            #region Q7
            //var result = Source.ProductList.Select((p, index) => new { Name = p.ProductName, Position = index + 1 });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Position}. {item.Name}");
            //}

            #endregion

            #region Q8
            //var result = Source.ProductList.OrderBy(c => c.Category).ThenByDescending(c => c.UnitPrice);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductName} - {item.UnitPrice}");
            //}
            #endregion

            #region Q9
            //var result = Source.ProductList
            //     .Where(p => p.Category == "Beverages")
            //      .OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item.ProductName} - {item.Category} - {item.UnitsInStock}");
            //}
            #endregion

            #region Q10
            var result =
                        from c in Source.CustomerList
                        from o in c.Orders
                        where (o.OrderDate.Year > 1997)
                        select (c.CustomerID, o.OrderDate);

            foreach (var o in result)
            {
                Console.WriteLine(o);
            }
            #endregion


        }
    }
}
