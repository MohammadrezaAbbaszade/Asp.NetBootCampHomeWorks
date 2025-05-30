namespace OOP___ObjectOriented_Programming___1.Hw3;

public class Order: IDiscountable
{
    public List<Product> Products { get; private set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }

        return total;
    }

    public override string ToString()
    {
        return $"Order Total: ${CalculateTotal()}";
    }

    public decimal ApplyDiscount(decimal _percentage, decimal amount)
    {
        return amount - (_percentage * amount / 100);
    }


    public static void Run()
    {
        //Clothings
        Clothing product1 = new Clothing();
        product1.Price = 100;
        Clothing product2 = new Clothing();
        product2.Price = 200;

        //Electronics
        Electronic product3 = new Electronic();
        product3.Price = 300;
        Electronic product4 = new Electronic();
        product4.Price = 400;

        //add orders clothings
        Order order1 = new Order();
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        //add orders electronics
        Order order2 = new Order();
        order2.AddProduct(product3);
        order2.AddProduct(product4);


        //apply discount
        decimal discount1 = product1.ApplyDiscount(10, product1.Price); //apply 10% discount
        Console.WriteLine($"Product 1 Price = {product1.Price}  PriceAfter(10%)Discount=${discount1}");
        decimal discount2 = product2.ApplyDiscount(10, product2.Price); //apply 10% discount
        Console.WriteLine($"Product 2 Price = {product2.Price}  PriceAfter(10%)Discount=${discount2}");
        decimal discount3 = product3.ApplyDiscount(40, product3.Price); //apply 40% discount
        Console.WriteLine($"Product 3 Price = {product3.Price}  PriceAfter(40%)Discount=${discount3}");
        decimal discount4 = product4.ApplyDiscount(50, product4.Price); //apply 50% discount
        Console.WriteLine($"Product 4 Price = {product4.Price}  PriceAfter(50%)Discount=${discount4}");
        
        Console.WriteLine($"Total after fixed amount 10% discount For Order1: ${order1.ApplyDiscount(10,order1.CalculateTotal())}");
        Console.WriteLine($"Total after fixed amount 30% discount For Order2: ${order1.ApplyDiscount(30,order2.CalculateTotal())}");
    }
}