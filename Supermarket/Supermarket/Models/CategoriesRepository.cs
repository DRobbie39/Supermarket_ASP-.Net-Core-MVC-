namespace Supermarket.Models
{
    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category {CategoryId = 1, Name = "Beverage", Description = "Beverage" },
            new Category {CategoryId = 2, Name = "Bakery", Description = "Bakery" },
            new Category {CategoryId = 3, Name = "Meat", Description = "Meat" }
        };

        //Phương thức thêm thể loại mới
        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(c => c.CategoryId);
            category.CategoryId = maxId + 1;
            _categories.Add(category);
        }

        //Phương thức lấy danh sách các thể loại
        public static List<Category> GetCategories() => _categories;

        //Phương thức lấy mã thể loại theo id
        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if(category != null)
            {
                return new Category
                {
                    CategoryId = category.CategoryId,
                    Name = category.Name,
                    Description = category.Description
                };
            }

            return null;
        }

        //Phương thức cập nhật thể loại
        public static void UpdateCategory(int categoryId, Category category)
        {
            if (categoryId != category.CategoryId)
                return;

            var categoryToUpdate = _categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if(categoryToUpdate != null)
            {
                categoryToUpdate.Name = category.Name;
                categoryToUpdate.Description = category.Description;
            }
        }

        //Phương thức xóa thể loại
        public static void DeleteCategory(int categoryId)
        {
            var category = _categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if(category != null)
            {
                _categories.Remove(category);
            }
        }
    }
}