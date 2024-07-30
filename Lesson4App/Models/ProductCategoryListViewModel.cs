namespace Lesson4App.Models
{
    public class ProductCategoryListViewModel
    {
        public IQueryable<ProductViewModel>? Products { get; set; }
        public IQueryable<CategoryViewModel>? Categories { get; set; }
    }
}
