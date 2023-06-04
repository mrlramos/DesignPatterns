// See https://aka.ms/new-console-template for more information
using SimpleFactoryExercise;
using SimpleFactoryExercise.Products;
using System.Reflection;

Console.WriteLine("Hello, World!");

try
{
    string stringProduct = Console.ReadLine();

    Product product = ProductSimpleFactory.CreateProduct(stringProduct);

    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);

    Type productType = product.GetType();
    PropertyInfo[] properties = productType.GetProperties();

    foreach (PropertyInfo propertyInfo in properties)
    {
        if (propertyInfo.Name != "Name" && propertyInfo.Name != "Price")
        {
            Console.WriteLine(propertyInfo.GetValue(product));
        }
    }

    Console.ReadKey();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}