USE [FoodDelivery]
GO
ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT [FK_Restaurants_Locations_LocationId]
GO
ALTER TABLE [dbo].[OrderStatuses] DROP CONSTRAINT [FK_OrderStatuses_StatusCatalogs_StatusCatalogId]
GO
ALTER TABLE [dbo].[OrderStatuses] DROP CONSTRAINT [FK_OrderStatuses_OrderPlaceds_OrderPlacedId]
GO
ALTER TABLE [dbo].[OrderPlaceds] DROP CONSTRAINT [FK_OrderPlaceds_Customers_CustomerId]
GO
ALTER TABLE [dbo].[OrderComments] DROP CONSTRAINT [FK_OrderComments_OrderPlaceds_OrderPlacedId]
GO
ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_MenuItems_Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[MenuItems] DROP CONSTRAINT [FK_MenuItems_MenuCategories_MenuCategoryId]
GO
ALTER TABLE [dbo].[InOrders] DROP CONSTRAINT [FK_InOrders_OrderPlaceds_OrderPlacedId]
GO
ALTER TABLE [dbo].[InOrders] DROP CONSTRAINT [FK_InOrders_MenuItems_MenuItemId]
GO
ALTER TABLE [dbo].[InOrders] DROP CONSTRAINT [FK_InOrders_IngredientToAdds_IngredientToAddId]
GO
ALTER TABLE [dbo].[InOrderIngredientToAdds] DROP CONSTRAINT [FK_InOrderIngredientToAdds_InOrders_InOrderId]
GO
ALTER TABLE [dbo].[InOrderIngredientToAdds] DROP CONSTRAINT [FK_InOrderIngredientToAdds_IngredientToAdds_IngredientToAddId]
GO
ALTER TABLE [dbo].[InOffers] DROP CONSTRAINT [FK_InOffers_Offers_OfferId]
GO
ALTER TABLE [dbo].[InOffers] DROP CONSTRAINT [FK_InOffers_MenuItems_MenuItemId]
GO
ALTER TABLE [dbo].[IngredientToAdds] DROP CONSTRAINT [FK_IngredientToAdds_MenuItems_MenuItemId]
GO
ALTER TABLE [dbo].[IngredientToAdds] DROP CONSTRAINT [FK_IngredientToAdds_IngredientCatalogs_IngredientCatalogId]
GO
ALTER TABLE [dbo].[CustomerRestaurantReviews] DROP CONSTRAINT [FK_CustomerRestaurantReviews_Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[CustomerRestaurantReviews] DROP CONSTRAINT [FK_CustomerRestaurantReviews_Customers_CustomerId]
GO
ALTER TABLE [dbo].[CustomerMenuReviews] DROP CONSTRAINT [FK_CustomerMenuReviews_MenuItems_MenuItemId]
GO
ALTER TABLE [dbo].[CustomerMenuReviews] DROP CONSTRAINT [FK_CustomerMenuReviews_Customers_CustomerId]
GO
/****** Object:  Table [dbo].[StatusCatalogs]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[StatusCatalogs]
GO
/****** Object:  Table [dbo].[Restaurants]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[Restaurants]
GO
/****** Object:  Table [dbo].[OrderStatuses]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[OrderStatuses]
GO
/****** Object:  Table [dbo].[OrderPlaceds]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[OrderPlaceds]
GO
/****** Object:  Table [dbo].[OrderComments]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[OrderComments]
GO
/****** Object:  Table [dbo].[Offers]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[Offers]
GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[MenuItems]
GO
/****** Object:  Table [dbo].[MenuCategories]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[MenuCategories]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[Locations]
GO
/****** Object:  Table [dbo].[InOrders]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[InOrders]
GO
/****** Object:  Table [dbo].[InOrderIngredientToAdds]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[InOrderIngredientToAdds]
GO
/****** Object:  Table [dbo].[InOffers]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[InOffers]
GO
/****** Object:  Table [dbo].[IngredientToAdds]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[IngredientToAdds]
GO
/****** Object:  Table [dbo].[IngredientCatalogs]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[IngredientCatalogs]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[Customers]
GO
/****** Object:  Table [dbo].[CustomerRestaurantReviews]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[CustomerRestaurantReviews]
GO
/****** Object:  Table [dbo].[CustomerMenuReviews]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[CustomerMenuReviews]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/03/2019 09:50:27 ******/
DROP TABLE [dbo].[__EFMigrationsHistory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/03/2019 09:50:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerMenuReviews]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerMenuReviews](
	[CustomerId] [int] NOT NULL,
	[MenuItemId] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_CustomerMenuReviews] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[MenuItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerRestaurantReviews]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerRestaurantReviews](
	[CustomerId] [int] NOT NULL,
	[RestaurantId] [int] NOT NULL,
	[rating] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_CustomerRestaurantReviews] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[DateOfBirth] [datetime2](7) NULL,
	[TimeJoined] [datetime2](7) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[MainPhoto] [nvarchar](200) NULL,
	[Address] [nvarchar](200) NULL,
	[PhoneNumber] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IngredientCatalogs]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredientCatalogs](
	[IngredientCatalogId] [int] IDENTITY(1,1) NOT NULL,
	[Ingredient] [nvarchar](200) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_IngredientCatalogs] PRIMARY KEY CLUSTERED 
(
	[IngredientCatalogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IngredientToAdds]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredientToAdds](
	[IngredientToAddId] [int] IDENTITY(1,1) NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[CanSelectMultiple] [bit] NOT NULL,
	[IngredientCatalogId] [int] NOT NULL,
	[MenuItemId] [int] NOT NULL,
 CONSTRAINT [PK_IngredientToAdds] PRIMARY KEY CLUSTERED 
(
	[IngredientToAddId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InOffers]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InOffers](
	[OfferId] [int] NOT NULL,
	[MenuItemId] [int] NOT NULL,
 CONSTRAINT [PK_InOffers] PRIMARY KEY CLUSTERED 
(
	[MenuItemId] ASC,
	[OfferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InOrderIngredientToAdds]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InOrderIngredientToAdds](
	[InOrderId] [int] NOT NULL,
	[IngredientToAddId] [int] NOT NULL,
 CONSTRAINT [PK_InOrderIngredientToAdds] PRIMARY KEY CLUSTERED 
(
	[InOrderId] ASC,
	[IngredientToAddId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InOrders]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InOrders](
	[InOrderId] [int] IDENTITY(1,1) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ItemPrice] [decimal](18, 2) NULL,
	[Comment] [nvarchar](max) NULL,
	[OrderPlacedId] [int] NOT NULL,
	[IngredientToAddId] [int] NULL,
	[MenuItemId] [int] NULL,
 CONSTRAINT [PK_InOrders] PRIMARY KEY CLUSTERED 
(
	[InOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Locations]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[LocationId] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](200) NULL,
	[CityName] [nvarchar](200) NULL,
	[RegionName] [nvarchar](200) NULL,
	[ZipCode] [int] NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MenuCategories]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuCategories](
	[MenuCategoryId] [int] IDENTITY(1,1) NOT NULL,
	[MenuCategoryName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_MenuCategories] PRIMARY KEY CLUSTERED 
(
	[MenuCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MenuItems]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuItems](
	[MenuItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Recipe] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[MenuCategoryId] [int] NOT NULL,
	[RestaurantId] [int] NOT NULL,
 CONSTRAINT [PK_MenuItems] PRIMARY KEY CLUSTERED 
(
	[MenuItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Offers]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offers](
	[OfferId] [int] IDENTITY(1,1) NOT NULL,
	[DateActiveFrom] [datetime2](7) NOT NULL,
	[TimeActiveFrom] [datetime2](7) NOT NULL,
	[DateActiveTo] [datetime2](7) NOT NULL,
	[TimeActiveTo] [datetime2](7) NOT NULL,
	[OfferType] [nvarchar](20) NULL,
	[OfferPrice] [decimal](18, 2) NULL,
	[CouponCode] [nvarchar](50) NULL,
	[CouponValue] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Offers] PRIMARY KEY CLUSTERED 
(
	[OfferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderComments]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderComments](
	[OrderCommentId] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [nvarchar](max) NOT NULL,
	[IsComplaint] [bit] NULL,
	[IsPraise] [bit] NULL,
	[OrderPlacedId] [int] NOT NULL,
 CONSTRAINT [PK_OrderComments] PRIMARY KEY CLUSTERED 
(
	[OrderCommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderPlaceds]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderPlaceds](
	[OrderPlacedId] [int] IDENTITY(1,1) NOT NULL,
	[OrderTime] [datetime2](7) NOT NULL,
	[EstimatedDeliveryTime] [nvarchar](50) NULL,
	[ActualDeliveryTime] [datetime2](7) NULL,
	[DeliveryAddress] [nvarchar](200) NOT NULL,
	[Comment] [nvarchar](200) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[DeliveryFees] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[FinalPrice] [decimal](18, 2) NOT NULL,
	[CustomerId] [int] NOT NULL,
 CONSTRAINT [PK_OrderPlaceds] PRIMARY KEY CLUSTERED 
(
	[OrderPlacedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderStatuses]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatuses](
	[OrderPlacedId] [int] NOT NULL,
	[StatusCatalogId] [int] NOT NULL,
 CONSTRAINT [PK_OrderStatuses] PRIMARY KEY CLUSTERED 
(
	[OrderPlacedId] ASC,
	[StatusCatalogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Restaurants]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurants](
	[RestaurantId] [int] IDENTITY(1,1) NOT NULL,
	[RestaurantName] [nvarchar](200) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[PhoneNumber] [int] NOT NULL,
	[PhotoUrl] [nvarchar](max) NULL,
	[StartHour] [nvarchar](max) NULL,
	[CloseHour] [nvarchar](max) NULL,
	[DaysOff] [nvarchar](max) NULL,
	[LocationId] [int] NOT NULL,
 CONSTRAINT [PK_Restaurants] PRIMARY KEY CLUSTERED 
(
	[RestaurantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StatusCatalogs]    Script Date: 19/03/2019 09:50:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusCatalogs](
	[StatusCatalogId] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusCatalogs] PRIMARY KEY CLUSTERED 
(
	[StatusCatalogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190207175731_FoodDeliveryDb_v0', N'2.1.4-rtm-31024')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190208122449_fixInOrderIssue', N'2.1.4-rtm-31024')
GO
INSERT [dbo].[CustomerRestaurantReviews] ([CustomerId], [RestaurantId], [rating], [Description]) VALUES (3, 3, 3, N'it can do better, the service is not good enough')
GO
INSERT [dbo].[CustomerRestaurantReviews] ([CustomerId], [RestaurantId], [rating], [Description]) VALUES (4, 3, 4, N'nice restaurant with awsome range of choices')
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

GO
INSERT [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [Gender], [DateOfBirth], [TimeJoined], [Email], [Password], [MainPhoto], [Address], [PhoneNumber]) VALUES (3, N'first1', N'last1', N'male', NULL, CAST(0x0700000000004C320B AS DateTime2), N'cust1@exemple.com', N'test', NULL, N'address1', 21211211)
GO
INSERT [dbo].[Customers] ([CustomerId], [FirstName], [LastName], [Gender], [DateOfBirth], [TimeJoined], [Email], [Password], [MainPhoto], [Address], [PhoneNumber]) VALUES (4, N'first2', N'last2', N'Female', NULL, CAST(0x0700000000006D320B AS DateTime2), N'cust2@exemple.com', N'test', NULL, N'address2', 20200200)
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[IngredientCatalogs] ON 

GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (1, N'ing1', N'desc1')
GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (2, N'ing2', N'desc2')
GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (3, N'ing3', N'desc3')
GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (4, N'ing4', N'desc4')
GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (5, N'ing5', N'desc5')
GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (6, N'ing6', N'desc6')
GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (7, N'ing7', N'desc7')
GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (8, N'ing8', N'desc8')
GO
INSERT [dbo].[IngredientCatalogs] ([IngredientCatalogId], [Ingredient], [Description]) VALUES (9, N'ing9', N'desc9')
GO
SET IDENTITY_INSERT [dbo].[IngredientCatalogs] OFF
GO
SET IDENTITY_INSERT [dbo].[IngredientToAdds] ON 

GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (1, CAST(3.00 AS Decimal(18, 2)), 1, 1, 3)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (2, CAST(3.00 AS Decimal(18, 2)), 1, 2, 3)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (3, CAST(3.00 AS Decimal(18, 2)), 1, 3, 3)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (4, CAST(3.00 AS Decimal(18, 2)), 0, 4, 3)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (5, CAST(3.00 AS Decimal(18, 2)), 0, 4, 3)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (8, CAST(3.00 AS Decimal(18, 2)), 1, 1, 5)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (9, CAST(3.00 AS Decimal(18, 2)), 1, 2, 5)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (10, CAST(3.00 AS Decimal(18, 2)), 0, 3, 5)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (11, CAST(3.00 AS Decimal(18, 2)), 1, 5, 6)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (12, CAST(3.00 AS Decimal(18, 2)), 1, 6, 6)
GO
INSERT [dbo].[IngredientToAdds] ([IngredientToAddId], [Price], [CanSelectMultiple], [IngredientCatalogId], [MenuItemId]) VALUES (14, CAST(3.00 AS Decimal(18, 2)), 1, 7, 6)
GO
SET IDENTITY_INSERT [dbo].[IngredientToAdds] OFF
GO
SET IDENTITY_INSERT [dbo].[Locations] ON 

GO
INSERT [dbo].[Locations] ([LocationId], [CountryName], [CityName], [RegionName], [ZipCode]) VALUES (1, N'tunisia', N'bizerte', N'manzel abderahman', 7035)
GO
INSERT [dbo].[Locations] ([LocationId], [CountryName], [CityName], [RegionName], [ZipCode]) VALUES (2, N'tunisia', N'bizerte', N'manzel jmil', 7034)
GO
INSERT [dbo].[Locations] ([LocationId], [CountryName], [CityName], [RegionName], [ZipCode]) VALUES (3, N'tunisia', N'bizerte', N'bizerte', 7033)
GO
SET IDENTITY_INSERT [dbo].[Locations] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuCategories] ON 

GO
INSERT [dbo].[MenuCategories] ([MenuCategoryId], [MenuCategoryName]) VALUES (1, N'cat1')
GO
INSERT [dbo].[MenuCategories] ([MenuCategoryId], [MenuCategoryName]) VALUES (2, N'cat2')
GO
INSERT [dbo].[MenuCategories] ([MenuCategoryId], [MenuCategoryName]) VALUES (3, N'cat3')
GO
INSERT [dbo].[MenuCategories] ([MenuCategoryId], [MenuCategoryName]) VALUES (4, N'cat4')
GO
SET IDENTITY_INSERT [dbo].[MenuCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuItems] ON 

GO
INSERT [dbo].[MenuItems] ([MenuItemId], [ItemName], [Description], [Recipe], [Price], [IsActive], [MenuCategoryId], [RestaurantId]) VALUES (3, N'item1', N'desc', N'rec1,rec2', CAST(15.00 AS Decimal(18, 2)), 1, 1, 3)
GO
INSERT [dbo].[MenuItems] ([MenuItemId], [ItemName], [Description], [Recipe], [Price], [IsActive], [MenuCategoryId], [RestaurantId]) VALUES (5, N'item2', N'desc', N'rec1,ttt2,tt3', CAST(10.00 AS Decimal(18, 2)), 1, 1, 3)
GO
INSERT [dbo].[MenuItems] ([MenuItemId], [ItemName], [Description], [Recipe], [Price], [IsActive], [MenuCategoryId], [RestaurantId]) VALUES (6, N'item3', N'desc3', N'rec8,rec2', CAST(8.00 AS Decimal(18, 2)), 1, 1, 3)
GO
INSERT [dbo].[MenuItems] ([MenuItemId], [ItemName], [Description], [Recipe], [Price], [IsActive], [MenuCategoryId], [RestaurantId]) VALUES (7, N'item4', N'desc4', N'rec1,rec2', CAST(16.00 AS Decimal(18, 2)), 1, 2, 3)
GO
INSERT [dbo].[MenuItems] ([MenuItemId], [ItemName], [Description], [Recipe], [Price], [IsActive], [MenuCategoryId], [RestaurantId]) VALUES (9, N'item5', N'desc5', N'rec1', CAST(22.50 AS Decimal(18, 2)), 1, 2, 3)
GO
SET IDENTITY_INSERT [dbo].[MenuItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

GO
INSERT [dbo].[Restaurants] ([RestaurantId], [RestaurantName], [Address], [Description], [PhoneNumber], [PhotoUrl], [StartHour], [CloseHour], [DaysOff], [LocationId]) VALUES (3, N'rest1', N'add1', N'desc1', 20111222, NULL, N'08:30', N'23:00', N'saturday,sunday', 1)
GO
INSERT [dbo].[Restaurants] ([RestaurantId], [RestaurantName], [Address], [Description], [PhoneNumber], [PhotoUrl], [StartHour], [CloseHour], [DaysOff], [LocationId]) VALUES (5, N'rest2', N'add2', N'desc2', 20159753, NULL, N'08:00', N'00:00', N'sunday', 1)
GO
INSERT [dbo].[Restaurants] ([RestaurantId], [RestaurantName], [Address], [Description], [PhoneNumber], [PhotoUrl], [StartHour], [CloseHour], [DaysOff], [LocationId]) VALUES (6, N'rest3', N'add3', N'desc1', 85456321, NULL, N'16:00', N'04:00', NULL, 2)
GO
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
ALTER TABLE [dbo].[CustomerMenuReviews]  WITH CHECK ADD  CONSTRAINT [FK_CustomerMenuReviews_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerMenuReviews] CHECK CONSTRAINT [FK_CustomerMenuReviews_Customers_CustomerId]
GO
ALTER TABLE [dbo].[CustomerMenuReviews]  WITH CHECK ADD  CONSTRAINT [FK_CustomerMenuReviews_MenuItems_MenuItemId] FOREIGN KEY([MenuItemId])
REFERENCES [dbo].[MenuItems] ([MenuItemId])
GO
ALTER TABLE [dbo].[CustomerMenuReviews] CHECK CONSTRAINT [FK_CustomerMenuReviews_MenuItems_MenuItemId]
GO
ALTER TABLE [dbo].[CustomerRestaurantReviews]  WITH CHECK ADD  CONSTRAINT [FK_CustomerRestaurantReviews_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerRestaurantReviews] CHECK CONSTRAINT [FK_CustomerRestaurantReviews_Customers_CustomerId]
GO
ALTER TABLE [dbo].[CustomerRestaurantReviews]  WITH CHECK ADD  CONSTRAINT [FK_CustomerRestaurantReviews_Restaurants_RestaurantId] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurants] ([RestaurantId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerRestaurantReviews] CHECK CONSTRAINT [FK_CustomerRestaurantReviews_Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[IngredientToAdds]  WITH CHECK ADD  CONSTRAINT [FK_IngredientToAdds_IngredientCatalogs_IngredientCatalogId] FOREIGN KEY([IngredientCatalogId])
REFERENCES [dbo].[IngredientCatalogs] ([IngredientCatalogId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[IngredientToAdds] CHECK CONSTRAINT [FK_IngredientToAdds_IngredientCatalogs_IngredientCatalogId]
GO
ALTER TABLE [dbo].[IngredientToAdds]  WITH CHECK ADD  CONSTRAINT [FK_IngredientToAdds_MenuItems_MenuItemId] FOREIGN KEY([MenuItemId])
REFERENCES [dbo].[MenuItems] ([MenuItemId])
GO
ALTER TABLE [dbo].[IngredientToAdds] CHECK CONSTRAINT [FK_IngredientToAdds_MenuItems_MenuItemId]
GO
ALTER TABLE [dbo].[InOffers]  WITH CHECK ADD  CONSTRAINT [FK_InOffers_MenuItems_MenuItemId] FOREIGN KEY([MenuItemId])
REFERENCES [dbo].[MenuItems] ([MenuItemId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InOffers] CHECK CONSTRAINT [FK_InOffers_MenuItems_MenuItemId]
GO
ALTER TABLE [dbo].[InOffers]  WITH CHECK ADD  CONSTRAINT [FK_InOffers_Offers_OfferId] FOREIGN KEY([OfferId])
REFERENCES [dbo].[Offers] ([OfferId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InOffers] CHECK CONSTRAINT [FK_InOffers_Offers_OfferId]
GO
ALTER TABLE [dbo].[InOrderIngredientToAdds]  WITH CHECK ADD  CONSTRAINT [FK_InOrderIngredientToAdds_IngredientToAdds_IngredientToAddId] FOREIGN KEY([IngredientToAddId])
REFERENCES [dbo].[IngredientToAdds] ([IngredientToAddId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InOrderIngredientToAdds] CHECK CONSTRAINT [FK_InOrderIngredientToAdds_IngredientToAdds_IngredientToAddId]
GO
ALTER TABLE [dbo].[InOrderIngredientToAdds]  WITH CHECK ADD  CONSTRAINT [FK_InOrderIngredientToAdds_InOrders_InOrderId] FOREIGN KEY([InOrderId])
REFERENCES [dbo].[InOrders] ([InOrderId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InOrderIngredientToAdds] CHECK CONSTRAINT [FK_InOrderIngredientToAdds_InOrders_InOrderId]
GO
ALTER TABLE [dbo].[InOrders]  WITH CHECK ADD  CONSTRAINT [FK_InOrders_IngredientToAdds_IngredientToAddId] FOREIGN KEY([IngredientToAddId])
REFERENCES [dbo].[IngredientToAdds] ([IngredientToAddId])
GO
ALTER TABLE [dbo].[InOrders] CHECK CONSTRAINT [FK_InOrders_IngredientToAdds_IngredientToAddId]
GO
ALTER TABLE [dbo].[InOrders]  WITH CHECK ADD  CONSTRAINT [FK_InOrders_MenuItems_MenuItemId] FOREIGN KEY([MenuItemId])
REFERENCES [dbo].[MenuItems] ([MenuItemId])
GO
ALTER TABLE [dbo].[InOrders] CHECK CONSTRAINT [FK_InOrders_MenuItems_MenuItemId]
GO
ALTER TABLE [dbo].[InOrders]  WITH CHECK ADD  CONSTRAINT [FK_InOrders_OrderPlaceds_OrderPlacedId] FOREIGN KEY([OrderPlacedId])
REFERENCES [dbo].[OrderPlaceds] ([OrderPlacedId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InOrders] CHECK CONSTRAINT [FK_InOrders_OrderPlaceds_OrderPlacedId]
GO
ALTER TABLE [dbo].[MenuItems]  WITH CHECK ADD  CONSTRAINT [FK_MenuItems_MenuCategories_MenuCategoryId] FOREIGN KEY([MenuCategoryId])
REFERENCES [dbo].[MenuCategories] ([MenuCategoryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MenuItems] CHECK CONSTRAINT [FK_MenuItems_MenuCategories_MenuCategoryId]
GO
ALTER TABLE [dbo].[MenuItems]  WITH CHECK ADD  CONSTRAINT [FK_MenuItems_Restaurants_RestaurantId] FOREIGN KEY([RestaurantId])
REFERENCES [dbo].[Restaurants] ([RestaurantId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MenuItems] CHECK CONSTRAINT [FK_MenuItems_Restaurants_RestaurantId]
GO
ALTER TABLE [dbo].[OrderComments]  WITH CHECK ADD  CONSTRAINT [FK_OrderComments_OrderPlaceds_OrderPlacedId] FOREIGN KEY([OrderPlacedId])
REFERENCES [dbo].[OrderPlaceds] ([OrderPlacedId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderComments] CHECK CONSTRAINT [FK_OrderComments_OrderPlaceds_OrderPlacedId]
GO
ALTER TABLE [dbo].[OrderPlaceds]  WITH CHECK ADD  CONSTRAINT [FK_OrderPlaceds_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderPlaceds] CHECK CONSTRAINT [FK_OrderPlaceds_Customers_CustomerId]
GO
ALTER TABLE [dbo].[OrderStatuses]  WITH CHECK ADD  CONSTRAINT [FK_OrderStatuses_OrderPlaceds_OrderPlacedId] FOREIGN KEY([OrderPlacedId])
REFERENCES [dbo].[OrderPlaceds] ([OrderPlacedId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderStatuses] CHECK CONSTRAINT [FK_OrderStatuses_OrderPlaceds_OrderPlacedId]
GO
ALTER TABLE [dbo].[OrderStatuses]  WITH CHECK ADD  CONSTRAINT [FK_OrderStatuses_StatusCatalogs_StatusCatalogId] FOREIGN KEY([StatusCatalogId])
REFERENCES [dbo].[StatusCatalogs] ([StatusCatalogId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderStatuses] CHECK CONSTRAINT [FK_OrderStatuses_StatusCatalogs_StatusCatalogId]
GO
ALTER TABLE [dbo].[Restaurants]  WITH CHECK ADD  CONSTRAINT [FK_Restaurants_Locations_LocationId] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Locations] ([LocationId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Restaurants] CHECK CONSTRAINT [FK_Restaurants_Locations_LocationId]
GO
