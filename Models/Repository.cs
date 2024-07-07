namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _product = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category {CategoryId = 1, Name = "Telefon"});
            _categories.Add(new Category {CategoryId = 2, Name = "Bilgisayar"});

            _product.Add(new Product {ProductId = 1, Name = "Iphone 14", 
                Price= 40000, IsActive = true, Image = "1.jpg", CategoryId = 1});

            _product.Add(new Product {ProductId = 2, Name = "Iphone 15", 
                Price= 45000, IsActive = false, Image = "2.jpg", CategoryId = 1});

            _product.Add(new Product {ProductId = 3, Name = "Iphone 16", 
                Price= 50000, IsActive = true, Image = "3.jpg", CategoryId = 1});

            _product.Add(new Product {ProductId = 4, Name = "Iphone 17", 
                Price= 60000, IsActive = false, Image = "4.jpg", CategoryId = 1});

            _product.Add(new Product {ProductId = 5, Name = "Macbook Air",
                Price= 70000, IsActive = false, Image = "5.jpg", CategoryId = 2});

            _product.Add(new Product {ProductId = 6, Name = "Macbook Pro",
                Price= 90000, IsActive = true, Image = "6.jpg", CategoryId = 2});
        }

        public static List<Product> Products
        {
            get{
                return _product;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _product.Add(entity);
        }

        public static void EditProduct(Product updateProduct)
        {
            var entity =_product.FirstOrDefault(p => p.ProductId == updateProduct.ProductId);

            if(entity != null)
            {
                entity.Name = updateProduct.Name;
                entity.Price = updateProduct.Price;
                entity.Image = updateProduct.Image;
                entity.CategoryId = updateProduct.CategoryId;
                entity.IsActive = updateProduct.IsActive;
            }
        }

        public static void EditIsActive(Product updateProduct)
        {
            var entity =_product.FirstOrDefault(p => p.ProductId == updateProduct.ProductId);

            if(entity != null)
            {
                entity.IsActive = updateProduct.IsActive;
            }
        }

        public static void DeleteProduct(Product entity)
        {
            var entit =_product.FirstOrDefault(p => p.ProductId == entity.ProductId);

            if(entit != null)
            {
                _product.Remove(entit);
            }
        }

        public static List<Category> Categories
        {
            get{
                return _categories;
            }
        }
    }
}