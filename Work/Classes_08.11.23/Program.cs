// See https://aka.ms/new-console-template for more information
using Classes_08._11._23;

Console.WriteLine("Hello, World!");

//class : sınıflar, nesneler
//OOP => Object Oriented Programming

//programın tanıyacağı kalıplar
//Product (name, price, stock)

//instance oluşturma
//kalıptan örnekler üretme
Product product = new Product("Laptop", 5000, 10);
Product product1 = new Product("Klavye", 600, 15);

Product product2 = new Product ();
product2.Name = "Mouse";
product2.Price = 500;
product2.Stock = 20;


//sınıf - obje farkı : obje sınfın içinde bulunan
//sınıflar kalıplardır, objeler bu kalıplardan üretilmiş örneklerdir. 

Console.WriteLine(product.Name + " isimli ürün fiyatı: " + product.Price);

Console.WriteLine(product2.Name + " isimli ürün fiyatı: " + product2.Price);


Product[] products = new Product[] { product, product1, product2 };
foreach (var produ in products)
{
    Console.WriteLine("Ürün ismi: " + produ.Name + "  Fiyatı:" + produ.Price + "  Stok Miktarı:" + produ.Stock);
}