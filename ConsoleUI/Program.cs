﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//ProductTest();
//CategoryTest();




static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetails();

    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
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

    var result = categoryManager.GetAll();
    foreach (var category in result.Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}