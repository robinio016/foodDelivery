﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using foodDeliveryBack.Data;

namespace fooddeliveryback.Migrations
{
    [DbContext(typeof(FoodDeliveryContext))]
    partial class FoodDeliveryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("foodDeliveryBack.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("MainPhoto")
                        .HasMaxLength(200);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int?>("PhoneNumber");

                    b.Property<DateTime?>("TimeJoined");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.CustomerMenuReview", b =>
                {
                    b.Property<int>("CustomerId");

                    b.Property<int>("MenuItemId");

                    b.Property<string>("Description");

                    b.Property<int>("Rating");

                    b.HasKey("CustomerId", "MenuItemId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("CustomerMenuReviews");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.CustomerRestaurantReview", b =>
                {
                    b.Property<int>("CustomerId");

                    b.Property<int>("RestaurantId");

                    b.Property<string>("Description");

                    b.Property<int>("rating");

                    b.HasKey("CustomerId", "RestaurantId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("CustomerRestaurantReviews");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.IngredientCatalog", b =>
                {
                    b.Property<int>("IngredientCatalogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Ingredient")
                        .HasMaxLength(200);

                    b.HasKey("IngredientCatalogId");

                    b.ToTable("IngredientCatalogs");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.IngredientToAdd", b =>
                {
                    b.Property<int>("IngredientToAddId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("CanSelectMultiple");

                    b.Property<int>("IngredientCatalogId");

                    b.Property<int>("MenuItemId");

                    b.Property<decimal?>("Price");

                    b.HasKey("IngredientToAddId");

                    b.HasIndex("IngredientCatalogId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("IngredientToAdds");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.InOffer", b =>
                {
                    b.Property<int>("MenuItemId");

                    b.Property<int>("OfferId");

                    b.HasKey("MenuItemId", "OfferId");

                    b.HasIndex("OfferId");

                    b.ToTable("InOffers");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.InOrder", b =>
                {
                    b.Property<int>("InOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<int?>("IngredientToAddId");

                    b.Property<decimal?>("ItemPrice");

                    b.Property<int?>("MenuItemId");

                    b.Property<int>("OrderPlacedId");

                    b.Property<int>("Quantity");

                    b.HasKey("InOrderId");

                    b.HasIndex("IngredientToAddId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderPlacedId");

                    b.ToTable("InOrders");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.InOrderIngredientToAdd", b =>
                {
                    b.Property<int>("InOrderId");

                    b.Property<int>("IngredientToAddId");

                    b.HasKey("InOrderId", "IngredientToAddId");

                    b.HasIndex("IngredientToAddId");

                    b.ToTable("InOrderIngredientToAdds");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasMaxLength(200);

                    b.Property<string>("CountryName")
                        .HasMaxLength(200);

                    b.Property<string>("RegionName")
                        .HasMaxLength(200);

                    b.Property<int?>("ZipCode");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.MenuCategory", b =>
                {
                    b.Property<int>("MenuCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MenuCategoryName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("MenuCategoryId");

                    b.ToTable("MenuCategories");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("MenuCategoryId");

                    b.Property<decimal>("Price");

                    b.Property<string>("Recipe");

                    b.Property<int>("RestaurantId");

                    b.HasKey("MenuItemId");

                    b.HasIndex("MenuCategoryId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CouponCode")
                        .HasMaxLength(50);

                    b.Property<decimal?>("CouponValue");

                    b.Property<DateTime>("DateActiveFrom");

                    b.Property<DateTime>("DateActiveTo");

                    b.Property<decimal?>("OfferPrice");

                    b.Property<string>("OfferType")
                        .HasMaxLength(20);

                    b.Property<DateTime>("TimeActiveFrom");

                    b.Property<DateTime>("TimeActiveTo");

                    b.HasKey("OfferId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.OrderComment", b =>
                {
                    b.Property<int>("OrderCommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<bool?>("IsComplaint");

                    b.Property<bool?>("IsPraise");

                    b.Property<int>("OrderPlacedId");

                    b.HasKey("OrderCommentId");

                    b.HasIndex("OrderPlacedId");

                    b.ToTable("OrderComments");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.OrderPlaced", b =>
                {
                    b.Property<int>("OrderPlacedId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ActualDeliveryTime");

                    b.Property<string>("Comment")
                        .HasMaxLength(200);

                    b.Property<int>("CustomerId");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<decimal?>("DeliveryFees");

                    b.Property<decimal?>("Discount");

                    b.Property<string>("EstimatedDeliveryTime")
                        .HasMaxLength(50);

                    b.Property<decimal>("FinalPrice");

                    b.Property<DateTime>("OrderTime");

                    b.Property<decimal>("Price");

                    b.HasKey("OrderPlacedId");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrderPlaceds");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.OrderStatus", b =>
                {
                    b.Property<int>("OrderPlacedId");

                    b.Property<int>("StatusCatalogId");

                    b.HasKey("OrderPlacedId", "StatusCatalogId");

                    b.HasIndex("StatusCatalogId");

                    b.ToTable("OrderStatuses");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("CloseHour");

                    b.Property<string>("DaysOff");

                    b.Property<string>("Description");

                    b.Property<int>("LocationId");

                    b.Property<int>("PhoneNumber");

                    b.Property<string>("PhotoUrl");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("StartHour");

                    b.HasKey("RestaurantId");

                    b.HasIndex("LocationId");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.StatusCatalog", b =>
                {
                    b.Property<int>("StatusCatalogId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("StatusCatalogId");

                    b.ToTable("StatusCatalogs");
                });

            modelBuilder.Entity("foodDeliveryBack.Model.CustomerMenuReview", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.Customer", "Customer")
                        .WithMany("CustomerMenuReviewList")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("foodDeliveryBack.Model.MenuItem", "MenuItem")
                        .WithMany("CustomerMenuReviewList")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.CustomerRestaurantReview", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.Customer", "Customer")
                        .WithMany("CustomerRestaurantReviewList")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("foodDeliveryBack.Model.Restaurant", "Restaurant")
                        .WithMany("CustomerRestaurantReviewList")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.IngredientToAdd", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.IngredientCatalog", "IngredientCatalog")
                        .WithMany("IngredientToAddList")
                        .HasForeignKey("IngredientCatalogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("foodDeliveryBack.Model.MenuItem", "MenuItem")
                        .WithMany("IngredientToAddList")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.InOffer", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.MenuItem", "MenuItem")
                        .WithMany("InOfferList")
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("foodDeliveryBack.Model.Offer", "Offer")
                        .WithMany("InOfferList")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.InOrder", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.IngredientToAdd")
                        .WithMany("InOrderList")
                        .HasForeignKey("IngredientToAddId");

                    b.HasOne("foodDeliveryBack.Model.MenuItem", "MenuItem")
                        .WithMany("InOrderList")
                        .HasForeignKey("MenuItemId");

                    b.HasOne("foodDeliveryBack.Model.OrderPlaced", "OrderPlaced")
                        .WithMany("InOrderList")
                        .HasForeignKey("OrderPlacedId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.InOrderIngredientToAdd", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.InOrder", "InOrder")
                        .WithMany("InOrderIngredientToAddList")
                        .HasForeignKey("InOrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("foodDeliveryBack.Model.IngredientToAdd", "IngredientToAdd")
                        .WithMany("InOrderIngredientToAddList")
                        .HasForeignKey("IngredientToAddId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.MenuItem", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.MenuCategory", "MenuCategory")
                        .WithMany("MenuItemList")
                        .HasForeignKey("MenuCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("foodDeliveryBack.Model.Restaurant", "Restaurant")
                        .WithMany("MenuItemList")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.OrderComment", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.OrderPlaced", "OrderPlaced")
                        .WithMany("OrderCommentList")
                        .HasForeignKey("OrderPlacedId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.OrderPlaced", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.Customer", "Customer")
                        .WithMany("OrderPlacedList")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.OrderStatus", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.OrderPlaced", "OrderPlaced")
                        .WithMany("OrderStatusList")
                        .HasForeignKey("OrderPlacedId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("foodDeliveryBack.Model.StatusCatalog", "StatusCatalog")
                        .WithMany("OrderStatusList")
                        .HasForeignKey("StatusCatalogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("foodDeliveryBack.Model.Restaurant", b =>
                {
                    b.HasOne("foodDeliveryBack.Model.Location", "Location")
                        .WithMany("RestaurantList")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}