using foodDeliveryBack.Model;
using Microsoft.EntityFrameworkCore;

namespace foodDeliveryBack.Data
{
    public class FoodDeliveryContext : DbContext
    {
        public FoodDeliveryContext(DbContextOptions<FoodDeliveryContext> options)
            : base(options)
        {   }
        
        public DbSet<Customer> Customers {get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Location> Locations { get; set; }
        
        public DbSet<OrderPlaced> OrderPlaceds { get; set; }
        public DbSet<InOrder> InOrders { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<IngredientCatalog> IngredientCatalogs { get; set; }
        public DbSet<IngredientToAdd> IngredientToAdds { get; set; }
        public DbSet<InOrderIngredientToAdd> InOrderIngredientToAdds { get; set; }
        public DbSet<InOffer> InOffers { get; set; }
        public DbSet<OrderComment> OrderComments { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<StatusCatalog> StatusCatalogs { get; set; }

        public DbSet<CustomerRestaurantReview> CustomerRestaurantReviews { get; set; }
        public DbSet<CustomerMenuReview> CustomerMenuReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //customer restaurant review
            modelBuilder.Entity<CustomerRestaurantReview>()
                .HasKey(cr => new {cr.CustomerId, cr.RestaurantId});

            modelBuilder.Entity<CustomerRestaurantReview>()
                .HasOne(cr => cr.Restaurant)
                .WithMany(r=>r.CustomerRestaurantReviewList)
                .HasForeignKey(cr => cr.RestaurantId);

            modelBuilder.Entity<CustomerRestaurantReview>()
                .HasOne(cr => cr.Customer)
                .WithMany(c=>c.CustomerRestaurantReviewList)
                .HasForeignKey(cr => cr.CustomerId);

            // customer Menu review
                modelBuilder.Entity<CustomerMenuReview>()
                .HasKey(cmr => new {cmr.CustomerId, cmr.MenuItemId});

            modelBuilder.Entity<CustomerMenuReview>()
                .HasOne(cmr => cmr.MenuItem)
                .WithMany(mIt=>mIt.CustomerMenuReviewList)
                .HasForeignKey(cmr => cmr.MenuItemId);

            modelBuilder.Entity<CustomerMenuReview>()
                .HasOne(cmr => cmr.Customer)
                .WithMany(c=>c.CustomerMenuReviewList)
                .HasForeignKey(cmr => cmr.CustomerId);

            //menuItem with offer many to many
            modelBuilder.Entity<InOffer>()
                .HasKey(inOff => new {inOff.MenuItemId, inOff.OfferId});

            modelBuilder.Entity<InOffer>()
                .HasOne(inOff => inOff.Offer)
                .WithMany(o => o.InOfferList)
                .HasForeignKey(inOff => inOff.OfferId);

            modelBuilder.Entity<InOffer>()
                .HasOne(inOff => inOff.MenuItem)
                .WithMany(mIt => mIt.InOfferList)
                .HasForeignKey(inOff => inOff.MenuItemId);

            //InOrder with IngredientToAdd many to many
            modelBuilder.Entity<InOrderIngredientToAdd>()
                .HasKey(ordIng => new {ordIng.InOrderId, ordIng.IngredientToAddId});

            modelBuilder.Entity<InOrderIngredientToAdd>()
                .HasOne(ordIng => ordIng.InOrder)
                .WithMany(inOrd => inOrd.InOrderIngredientToAddList)
                .HasForeignKey(ordIng => ordIng.InOrderId);

            modelBuilder.Entity<InOrderIngredientToAdd>()
                .HasOne(ordIng => ordIng.IngredientToAdd)
                .WithMany(ingToAdd => ingToAdd.InOrderIngredientToAddList)
                .HasForeignKey(ordIng => ordIng.IngredientToAddId);

            
            //InOrder with IngredientToAdd many to many
            modelBuilder.Entity<OrderStatus>()
                .HasKey(os => new {os.OrderPlacedId, os.StatusCatalogId});

            modelBuilder.Entity<OrderStatus>()
                .HasOne(os => os.OrderPlaced)
                .WithMany(op => op.OrderStatusList)
                .HasForeignKey(os => os.OrderPlacedId);

            modelBuilder.Entity<OrderStatus>()
                .HasOne(os => os.StatusCatalog)
                .WithMany(sc => sc.OrderStatusList)
                .HasForeignKey(os => os.StatusCatalogId);
        }
    }
}