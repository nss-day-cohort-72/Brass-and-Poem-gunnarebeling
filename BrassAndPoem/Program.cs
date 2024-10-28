
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List <Product> products = new List<Product>
{
    new Product()
            {
                Name = "Trumpet",
                Price = 299.99m,
                ProductTypeId = 1 
            },
            new Product()
            {
                Name = "Trombone",
                Price = 349.50m,
                ProductTypeId = 1 
            },
            new Product()
            {
                Name = "French Horn",
                Price = 999.99m,
                ProductTypeId = 1 
            },
            new Product()
            {
                Name = "Collected Poems",
                Price = 15.99m,
                ProductTypeId = 2 
            },
            new Product()
            {
                Name = "Nature's Verses",
                Price = 12.50m,
                ProductTypeId = 2 
            }
    
};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>
{
    new ProductType()
    {
        Id = 1,
        Title = "Brass Instrument"
    },
    new ProductType()
    {
        Id = 2,
        Title = "Poem Book"
    }
};
//put your greeting here
string greeting = "Hello! welcome to Brass and Poem!";
Console.WriteLine(greeting);
//implement your loop here
int choice = 0;
while (choice != 5)
{   
    Console.WriteLine(@"choose an option:");
    DisplayMenu();
    choice = int.Parse(Console.ReadLine().Trim());
    switch (choice)
    {
        case 1:
            DisplayAllProducts(products,productTypes);
            break;
        case 2:
            DeleteProduct(products,productTypes);
            break;
        case 3:
            AddProduct(products,productTypes);
            break;
        case 4:
            UpdateProduct(products,productTypes);
            break;
        case 5:
            Console.WriteLine("BYE!");
            break;
        
    }
}

void DisplayMenu()
{
    Console.WriteLine(@"1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit
");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {   
        string type = productTypes.First( t => t.Id == products[i].ProductTypeId).Title;
        Console.WriteLine($"{i + 1}. {products[i].Name} - Price: ${products[i].Price:F2} - Type: {type}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {   
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
    Console.WriteLine("select which product to delete:");
    int response = int.Parse(Console.ReadLine().Trim());
    products.RemoveAt(response - 1);
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter the name of the new product");
    string newName = Console.ReadLine();
    Console.WriteLine("Enter the Price of the new product:");
    decimal newPrice = decimal.Parse(Console.ReadLine().Trim());
    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }
    Console.WriteLine("select which type the product is:");
    int newType = int.Parse(Console.ReadLine().Trim());

    Product newProduct = 
        new Product()
            {
                Name = newName,
                Price = newPrice,
                ProductTypeId = newType
            };
    products.Add(newProduct);
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name}");
    }
    Console.WriteLine("select which product to update:");
    int productChoiceIndex = int.Parse(Console.ReadLine().Trim());

    Product chosenProduct = products[productChoiceIndex - 1];
    
    Console.WriteLine("update the name:");
    string newName = Console.ReadLine();
    if (string.IsNullOrEmpty(newName))
    {
        newName = chosenProduct.Name;
    }
    Console.WriteLine("update the Price:");
    decimal newPrice;
    string newPriceStr = Console.ReadLine().Trim();
    if (string.IsNullOrEmpty(newPriceStr))
    {
        newPrice = chosenProduct.Price;
    }
    else
    {
        newPrice = decimal.Parse(newPriceStr);
    }
    
    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }
    Console.WriteLine("update the product type select the type:");
    int newTypeId;
    string newTypeIdStr = Console.ReadLine().Trim();
    if (string.IsNullOrEmpty(newTypeIdStr))
    {
        newTypeId = chosenProduct.ProductTypeId;
    }
    else
    {
        newTypeId = int.Parse(newTypeIdStr);
    }

    Product updatedProduct = 
    new Product()
        {
            Name = newName,
            Price = newPrice,
            ProductTypeId = newTypeId
        };
    products[productChoiceIndex -1] = updatedProduct;





    

}

// don't move or change this!
public partial class Program { }