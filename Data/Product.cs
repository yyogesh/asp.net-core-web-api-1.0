namespace webapi_core_project.Data;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public ProductType ProductType { get; set; }

}

public enum ProductType
{
    CPU,
    Electronics,
    Books,
    Others
}
