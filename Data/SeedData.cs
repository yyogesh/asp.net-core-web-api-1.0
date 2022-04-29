namespace webapi_core_project.Data
{
    public static class SeedData
    {
        public static void Seed(this ProductDbContext context)
        {
            if (!context.Products.Any())
            {
                var products = new List<Product>()
                {
                    new Product() { ID = 1, Name = "CPU", Description = "CPU", Price = 100, ProductType = ProductType.CPU },
                    new Product() { ID = 2, Name = "Electronics", Description = "Electronics", Price = 200, ProductType = ProductType.Electronics },
                    new Product() { ID = 3, Name = "Books", Description = "Books", Price = 300, ProductType = ProductType.Books },
                    new Product() { ID = 4, Name = "Others", Description = "Others", Price = 400, ProductType = ProductType.Others }
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}