using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

// SOLID 
// O Harfi = Open Closed Principle
ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetAllByUnitPrice(40,100))
{
    Console.WriteLine(product.ProductName);
}
