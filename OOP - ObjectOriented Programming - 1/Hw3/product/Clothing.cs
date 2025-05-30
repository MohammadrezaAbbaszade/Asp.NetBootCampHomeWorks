namespace OOP___ObjectOriented_Programming___1.Hw3;

public class Clothing : Product, IDiscountable
{
    public int Size { get; set; }
    public string Material { get; set; }

    public decimal ApplyDiscount(decimal _percentage,decimal amount)
    {
        return amount - (_percentage * amount / 100);
    }
    
    public override string ToString()
    {
        return $"Price = {Price}";
    }
}