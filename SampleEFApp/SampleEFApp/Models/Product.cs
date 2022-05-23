namespace SampleEFApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public override bool Equals(object obj)
        {
            return this.Id.Equals(((Product)obj).Id);
        }
        public Product()
        {

        }
        public Product(int id, string name, float price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
