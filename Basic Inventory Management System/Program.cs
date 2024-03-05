using System.Xml.Linq;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }


    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;

    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        QuantityInStock += additionalQuantity;

    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        else
        {
            Console.WriteLine("Error: Not enough stock available.");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;

    }

    // Print item details
    public void PrintDetails()
    {

        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: ${Price:F2}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");

    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // Printing initial details
        Console.WriteLine("Initial Item Details:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // Selling some items
        Console.WriteLine("Selling Items:");
        item1.SellItem(3);
        item2.SellItem(20); // Trying to sell more than in stock
        Console.WriteLine();

        // Restocking an item
        Console.WriteLine("Restocking Items:");
        item2.RestockItem(5);
        Console.WriteLine();

        // Checking if an item is in stock
        Console.WriteLine("Checking Stock:");
        Console.WriteLine($"Is Laptop in stock? {item1.IsInStock()}");
        Console.WriteLine($"Is Smartphone in stock? {item2.IsInStock()}");

    }
}
