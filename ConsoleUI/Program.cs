﻿// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

Console.WriteLine("Hello, World!");
ProductManager productManager = new ProductManager(new EfProductDal());

//foreach (var product in productManager.GetAllByCategoryId(3))
//{
//    Console.WriteLine(product.ProductName);
//}
Console.WriteLine("...........................................");
foreach (var product in productManager.GetByUnitPrice(5, 20))
{
    Console.WriteLine(product.ProductName);
}