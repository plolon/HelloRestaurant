using Hello.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hello.Services.ProductAPI.Repositories.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                ProductId = 1,
                Name = "Creamy Tomato Pasta",
                Price = 17.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://cdn.apartmenttherapy.info/image/upload/f_jpg,q_auto:eco,c_fill,g_auto,w_1500,ar_4:3/k%2Farchive%2F0eb929bc2c007ebf6009316a327b1e37587045a4",
                CategoryName = "Entree"
            });
            builder.HasData(new Product
            {
                ProductId = 2,
                Name = "Stuffed Mushrooms",
                Price = 11.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://i2.wp.com/www.downshiftology.com/wp-content/uploads/2021/11/Stuffed-Mushrooms-main-1-1.jpg",
                CategoryName = "Appetizer"
            });
            builder.HasData(new Product
            {
                ProductId = 3,
                Name = "French Fries",
                Price = 12.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://www.thespruceeats.com/thmb/IHKuXcx3uUI1IWkM_cnnQdFH-zQ=/3485x2323/filters:fill(auto,1)/how-to-make-homemade-french-fries-2215971-hero-01-02f62a016f3e4aa4b41d0c27539885c3.jpg",
                CategoryName = "Appetizer"
            });
            builder.HasData(new Product
            {
                ProductId = 4,
                Name = "Apple Pie",
                Price = 10.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://ocdn.eu/pulscms-transforms/1/rlWk9kpTURBXy9iZTNhYjlkNjNmNDQzZmE2MzI1YWQwOGU0M2U3Nzk3ZC5qcGeTlQMAzMLNFMLNC62TCaY4YTBhZWMGkwXNBLDNAnaBoTAB/apple-pie.jpg",
                CategoryName = "Dessert"
            });
            builder.HasData(new Product
            {
                ProductId = 5,
                Name = "Schwarzwald Pie",
                Price = 13.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://www.bakinglikeachef.com/wp-content/uploads/Black-Forest-Cake-7.jpg",
                CategoryName = "Dessert"
            });
            builder.HasData(new Product
            {
                ProductId = 6,
                Name = "Crockpot Chicken and Dumplings",
                Price = 21.99,
                Description = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "https://hips.hearstapps.com/vidthumb/images/delish-crockpot-chicken-dumplings-1519941256.jpg",
                CategoryName = "Entree"
            });
        }
    }
}
