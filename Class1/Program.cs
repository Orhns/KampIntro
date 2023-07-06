

Product product1 = new Product();
product1.Title = "Stevia";
product1.Category = "Sweeteners";
product1.price = 68.99;

Product product2 = new Product();
product2.Title = "Peanut Butter";
product2.Category = "Dairy Products";
product2.price = 48.99;

Product product3 = new Product();
product3.Title = "Tomatoes";
product3.Category = "Vegetables";
product3.price = 24.99;

Product[] products = new Product[] { product1, product2, product3 };
Console.WriteLine("-----------foreach---------------");
foreach (var item in products)
{
    Console.WriteLine(item.Title + " - " + item.price + " / ");
}

Console.WriteLine("--------------for------------------");
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].Title + " - " + products[i].price + " / ");
}
Console.WriteLine("--------------while------------------");
int counter = 0;
while (products.Length>=counter)
{
    Console.WriteLine(products[counter].Title + " - " + products[counter].price + " / ");
    counter++;
}
class Product
{
    public string? Title { get; set; }
    public string? Category { get; set; }
    public double price { get; set; }

}


