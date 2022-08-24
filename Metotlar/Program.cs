using Metotlar;

Product product1 = new Product(); 
product1.Name = "Elma";
product1.Price = 99;
product1.Explanation = "Amasya elması";
product1.Id = 123;

Product product2 = new Product();
product2.Name = "Çilek";
product2.Price = 88;
product2.Explanation = "Çilek gibi çilek";
product2.Id = 234;

Product product3 = new Product();
product3.Name = "Ananas";
product3.Price = 77;
product3.Explanation = "Ananas aldırdım";
product3.Id = 345;

Product[] products = new Product[] { product1, product2, product3 };

foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Explanation);
    Console.WriteLine(product.Id);
    Console.WriteLine("-----------------------------------");
}

Console.WriteLine("---------------Metotlar--------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
