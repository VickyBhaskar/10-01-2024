// See https://aka.ms/new-console-template for more information
using ProductHandling;
List<Product> products = new List<Product>()
{
    new Product() { PName ="Mobile1",PPrice=6700.00,PBrand="Samsung",MfgDate = new DateTime(day: 12, month: 08, year:2012), ExpDate = new DateTime(day: 12, month: 11, year:2022)},
    new Product() { PName ="Mobile2",PPrice=7700.00,PBrand="Apple",MfgDate = new DateTime(day: 11, month: 09, year:2011), ExpDate = new DateTime(day: 22, month: 01, year:2021)},
    new Product() { PName ="Mobile3",PPrice=5700.00,PBrand="RealMe",MfgDate = new DateTime(day: 10, month: 07, year:2008), ExpDate = new DateTime(day: 20, month: 10, year:2020)},
    new Product() { PName ="Mobile4",PPrice=3700.00,PBrand="Redmi",MfgDate = new DateTime(day: 22, month: 06, year:2010), ExpDate = new DateTime(day: 10, month: 12, year:2023)},
};
Console.WriteLine("PName\t PPrice \t PBrand \t MfgDate \t ExpDate");
foreach (Product prd in products)
{
    Console.Write(prd.PName + "\t \t");
    Console.Write(prd.PPrice + "\t \t");
    Console.Write(prd.PBrand + "\t \t");
    Console.Write(prd.MfgDate.ToLongDateString() + "\t \t");
    Console.Write(prd.ExpDate.ToLongDateString());
    Console.WriteLine("\n");
}
