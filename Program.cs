using Task_2___Random_Numbers_Searching_Sorting;
// Create a list of 10 Random Products
List<Product> randomProducts = new List<Product>();
for (int i = 0; i < 10; i++)
{
    randomProducts.Add(new Product($"Product {i + 1}"));
}

// Create a Product Manager with the list of random products as its catalog 
ProductManager productManager = new ProductManager(randomProducts);

// Sort the product catalog by product id
List<Product> sortedCatalog = productManager.SortProducts();

// Display the sorted product catalog for the Product Manager created
Console.WriteLine("Product Catalog Sorted by Product ID: ");
foreach (Product product in sortedCatalog)
{
    Console.WriteLine($"ID : {product.Id}\t Name : {product.Name}");
}

// Search for a product by id
long productIdToSearch = sortedCatalog[0].Id ; // Change this to the desired product id to search
Product foundProduct = productManager.SearchProduct(productIdToSearch);
if (foundProduct != null)
{
    Console.WriteLine($"Product found: ID : {foundProduct.Id}\t Name : {foundProduct.Name}");
}
else
{
    Console.WriteLine("Product not found.");
}
