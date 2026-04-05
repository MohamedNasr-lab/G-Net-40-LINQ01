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
            var result = Source.ProductList.Where(c => c.Category == "Seafood");
            foreach (var product in result)
            {
                Console.WriteLine($"product name is {product.ProductName} ");
                Console.WriteLine($"product price is {product.UnitPrice} ");
            }
            #endregion


        }
    }
}
