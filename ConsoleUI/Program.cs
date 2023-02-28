using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

// SOLID 
// O Harfi = Open Closed Principle
// IoC
// DTO = Data Transformation Object

 ProductTest();

// CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

         var result = productManager.GetProductDetails();

        if (result.Success)
       {
        foreach (var product in result.Data )
        {
            Console.WriteLine(product.ProductName + " / " + product.CategoryName);

        }
    }
       else
    {
        Console.WriteLine(result.Message);
    }
        
    
}


static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine("{0} / {1} ", category.CategoryId, category.CategoryName);
    }
}  