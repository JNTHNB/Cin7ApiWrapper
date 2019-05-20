namespace Cin7ApiWrapper.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public bool IsActive { get; set; }
        public int Sort { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
