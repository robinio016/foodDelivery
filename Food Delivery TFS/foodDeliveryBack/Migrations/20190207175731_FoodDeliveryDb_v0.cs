using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fooddeliveryback.Migrations
{
    public partial class FoodDeliveryDb_v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 200, nullable: false),
                    LastName = table.Column<string>(maxLength: 200, nullable: false),
                    Gender = table.Column<string>(maxLength: 10, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    TimeJoined = table.Column<DateTime>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 20, nullable: false),
                    MainPhoto = table.Column<string>(maxLength: 200, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    PhoneNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "IngredientCatalogs",
                columns: table => new
                {
                    IngredientCatalogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ingredient = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientCatalogs", x => x.IngredientCatalogId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(maxLength: 200, nullable: true),
                    CityName = table.Column<string>(maxLength: 200, nullable: true),
                    RegionName = table.Column<string>(maxLength: 200, nullable: true),
                    ZipCode = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    MenuCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MenuCategoryName = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.MenuCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    OfferId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateActiveFrom = table.Column<DateTime>(nullable: false),
                    TimeActiveFrom = table.Column<DateTime>(nullable: false),
                    DateActiveTo = table.Column<DateTime>(nullable: false),
                    TimeActiveTo = table.Column<DateTime>(nullable: false),
                    OfferType = table.Column<string>(maxLength: 20, nullable: true),
                    OfferPrice = table.Column<decimal>(nullable: true),
                    CouponCode = table.Column<string>(maxLength: 50, nullable: true),
                    CouponValue = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.OfferId);
                });

            migrationBuilder.CreateTable(
                name: "StatusCatalogs",
                columns: table => new
                {
                    StatusCatalogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StatusName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusCatalogs", x => x.StatusCatalogId);
                });

            migrationBuilder.CreateTable(
                name: "OrderPlaceds",
                columns: table => new
                {
                    OrderPlacedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    EstimatedDeliveryTime = table.Column<string>(maxLength: 50, nullable: true),
                    ActualDeliveryTime = table.Column<DateTime>(nullable: true),
                    DeliveryAddress = table.Column<string>(maxLength: 200, nullable: false),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    DeliveryFees = table.Column<decimal>(nullable: true),
                    Discount = table.Column<decimal>(nullable: true),
                    FinalPrice = table.Column<decimal>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPlaceds", x => x.OrderPlacedId);
                    table.ForeignKey(
                        name: "FK_OrderPlaceds_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RestaurantName = table.Column<string>(maxLength: 200, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    StartHour = table.Column<string>(nullable: true),
                    CloseHour = table.Column<string>(nullable: true),
                    DaysOff = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                    table.ForeignKey(
                        name: "FK_Restaurants_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderComments",
                columns: table => new
                {
                    OrderCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Comment = table.Column<string>(nullable: false),
                    IsComplaint = table.Column<bool>(nullable: true),
                    IsPraise = table.Column<bool>(nullable: true),
                    OrderPlacedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderComments", x => x.OrderCommentId);
                    table.ForeignKey(
                        name: "FK_OrderComments_OrderPlaceds_OrderPlacedId",
                        column: x => x.OrderPlacedId,
                        principalTable: "OrderPlaceds",
                        principalColumn: "OrderPlacedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    OrderPlacedId = table.Column<int>(nullable: false),
                    StatusCatalogId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => new { x.OrderPlacedId, x.StatusCatalogId });
                    table.ForeignKey(
                        name: "FK_OrderStatuses_OrderPlaceds_OrderPlacedId",
                        column: x => x.OrderPlacedId,
                        principalTable: "OrderPlaceds",
                        principalColumn: "OrderPlacedId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderStatuses_StatusCatalogs_StatusCatalogId",
                        column: x => x.StatusCatalogId,
                        principalTable: "StatusCatalogs",
                        principalColumn: "StatusCatalogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRestaurantReviews",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: false),
                    rating = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRestaurantReviews", x => new { x.CustomerId, x.RestaurantId });
                    table.ForeignKey(
                        name: "FK_CustomerRestaurantReviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerRestaurantReviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerMenuReviews",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false),
                    MenuItemId = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMenuReviews", x => new { x.CustomerId, x.MenuItemId });
                    table.ForeignKey(
                        name: "FK_CustomerMenuReviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientToAdds",
                columns: table => new
                {
                    IngredientToAddId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: true),
                    CanSelectMultiple = table.Column<bool>(nullable: false),
                    IngredientCatalogId = table.Column<int>(nullable: false),
                    MenuItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientToAdds", x => x.IngredientToAddId);
                    table.ForeignKey(
                        name: "FK_IngredientToAdds_IngredientCatalogs_IngredientCatalogId",
                        column: x => x.IngredientCatalogId,
                        principalTable: "IngredientCatalogs",
                        principalColumn: "IngredientCatalogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InOrders",
                columns: table => new
                {
                    InOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    ItemPrice = table.Column<decimal>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    OrderPlacedId = table.Column<int>(nullable: false),
                    IngredientToAddId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOrders", x => x.InOrderId);
                    table.ForeignKey(
                        name: "FK_InOrders_IngredientToAdds_IngredientToAddId",
                        column: x => x.IngredientToAddId,
                        principalTable: "IngredientToAdds",
                        principalColumn: "IngredientToAddId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InOrders_OrderPlaceds_OrderPlacedId",
                        column: x => x.OrderPlacedId,
                        principalTable: "OrderPlaceds",
                        principalColumn: "OrderPlacedId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InOrderIngredientToAdds",
                columns: table => new
                {
                    InOrderId = table.Column<int>(nullable: false),
                    IngredientToAddId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOrderIngredientToAdds", x => new { x.InOrderId, x.IngredientToAddId });
                    table.ForeignKey(
                        name: "FK_InOrderIngredientToAdds_InOrders_InOrderId",
                        column: x => x.InOrderId,
                        principalTable: "InOrders",
                        principalColumn: "InOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InOrderIngredientToAdds_IngredientToAdds_IngredientToAddId",
                        column: x => x.IngredientToAddId,
                        principalTable: "IngredientToAdds",
                        principalColumn: "IngredientToAddId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    MenuItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemName = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Recipe = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    MenuCategoryId = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: false),
                    InOrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.MenuItemId);
                    table.ForeignKey(
                        name: "FK_MenuItems_InOrders_InOrderId",
                        column: x => x.InOrderId,
                        principalTable: "InOrders",
                        principalColumn: "InOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItems_MenuCategories_MenuCategoryId",
                        column: x => x.MenuCategoryId,
                        principalTable: "MenuCategories",
                        principalColumn: "MenuCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuItems_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InOffers",
                columns: table => new
                {
                    OfferId = table.Column<int>(nullable: false),
                    MenuItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOffers", x => new { x.MenuItemId, x.OfferId });
                    table.ForeignKey(
                        name: "FK_InOffers_MenuItems_MenuItemId",
                        column: x => x.MenuItemId,
                        principalTable: "MenuItems",
                        principalColumn: "MenuItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InOffers_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "OfferId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMenuReviews_MenuItemId",
                table: "CustomerMenuReviews",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRestaurantReviews_RestaurantId",
                table: "CustomerRestaurantReviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientToAdds_IngredientCatalogId",
                table: "IngredientToAdds",
                column: "IngredientCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientToAdds_MenuItemId",
                table: "IngredientToAdds",
                column: "MenuItemId");

            migrationBuilder.CreateIndex(
                name: "IX_InOffers_OfferId",
                table: "InOffers",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_InOrderIngredientToAdds_IngredientToAddId",
                table: "InOrderIngredientToAdds",
                column: "IngredientToAddId");

            migrationBuilder.CreateIndex(
                name: "IX_InOrders_IngredientToAddId",
                table: "InOrders",
                column: "IngredientToAddId");

            migrationBuilder.CreateIndex(
                name: "IX_InOrders_OrderPlacedId",
                table: "InOrders",
                column: "OrderPlacedId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_InOrderId",
                table: "MenuItems",
                column: "InOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_MenuCategoryId",
                table: "MenuItems",
                column: "MenuCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItems_RestaurantId",
                table: "MenuItems",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderComments_OrderPlacedId",
                table: "OrderComments",
                column: "OrderPlacedId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPlaceds_CustomerId",
                table: "OrderPlaceds",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatuses_StatusCatalogId",
                table: "OrderStatuses",
                column: "StatusCatalogId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_LocationId",
                table: "Restaurants",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerMenuReviews_MenuItems_MenuItemId",
                table: "CustomerMenuReviews",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "MenuItemId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientToAdds_MenuItems_MenuItemId",
                table: "IngredientToAdds",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "MenuItemId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPlaceds_Customers_CustomerId",
                table: "OrderPlaceds");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientToAdds_MenuItems_MenuItemId",
                table: "IngredientToAdds");

            migrationBuilder.DropTable(
                name: "CustomerMenuReviews");

            migrationBuilder.DropTable(
                name: "CustomerRestaurantReviews");

            migrationBuilder.DropTable(
                name: "InOffers");

            migrationBuilder.DropTable(
                name: "InOrderIngredientToAdds");

            migrationBuilder.DropTable(
                name: "OrderComments");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "StatusCatalogs");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "InOrders");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "IngredientToAdds");

            migrationBuilder.DropTable(
                name: "OrderPlaceds");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "IngredientCatalogs");
        }
    }
}
