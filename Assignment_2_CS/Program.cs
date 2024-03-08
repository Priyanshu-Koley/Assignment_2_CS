class Program
{
    static void Main(string[] args)
    {
        // Inventory with pre-added products
        List<Product> inventory =
        [
            new Product("lettuce", 10.5, 50, "Leafy green"),
            new Product("cabbage", 20, 100, "Cruciferous"),
            new Product("pumpkin", 30, 30, "Marrow"),
            new Product("cauliflower", 10, 25, "Cruciferous"),
            new Product("zucchini", 20.5, 50, "Marrow"),
            new Product("yam", 30, 50, "Root"),
            new Product("spinach", 10, 100, "Leafy green"),
            new Product("broccoli", 20.2, 75, "Cruciferous"),
            new Product("garlic", 30, 20, "Leafy green"),
            new Product("silverbeet", 10, 50, "Marrow")
        ];

        // Print the total number of products
        Console.WriteLine("Total number of products: " + inventory.Count);

        // Add a new product
        Product newProduct = new Product("Potato", 10, 50, "Root");
        inventory.Add(newProduct);
        Console.WriteLine("\nAdded new product: " + newProduct.ToString());
        // Print the total number of products
        Console.WriteLine("Total number of products: " + inventory.Count);

        // Print all products of type Leafy green
        Console.WriteLine("\nProducts of type Leafy green:");
        foreach (Product product in inventory.Where(p => p.Type == "Leafy green"))
        {
            Console.WriteLine(product.ToString());
        }

        // Remove garlic from the list
        inventory.RemoveAll(p => p.Name == "garlic");
        Console.WriteLine("\nRemoved garlic from the list");
        Console.WriteLine("Total number of products left: " + inventory.Count);

        // Add 50 cabbages to the inventory
        int additionalCabbages = 50;
        Product cabbage = inventory.FirstOrDefault(p => p.Name == "cabbage");
        if (cabbage != null)
        {
            cabbage.Quantity += additionalCabbages;
        }
        Console.WriteLine("\nAdded " + additionalCabbages + " cabbages to the inventory");
        Console.WriteLine("Final quantity of cabbage in inventory: " + cabbage.Quantity);

        // Calculate total cost for given purchases
        double lettucePrice = inventory.FirstOrDefault(p => p.Name == "lettuce")?.Price ?? 0;
        double zucchiniPrice = inventory.FirstOrDefault(p => p.Name == "zucchini")?.Price ?? 0;
        double broccoliPrice = inventory.FirstOrDefault(p => p.Name == "broccoli")?.Price ?? 0;
        double totalCost = (lettucePrice * 1) + (zucchiniPrice * 2) + (broccoliPrice * 1);
        Console.WriteLine("\nTotal cost for purchasing 1kg lettuce, 2kg zucchini, and 1kg broccoli: Rs." + totalCost);
    }
}

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Type { get; set; }

    public Product(string name, double price, int quantity, string type)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Type = type;
    }

    public override string ToString()
    {
        return $"{Name}, Rs.{Price}, {Quantity}, {Type}";
    }
}
