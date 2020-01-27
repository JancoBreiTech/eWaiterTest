﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Models
{
    public partial class eWaiterTestContext : DbContext
    {
        public eWaiterTestContext()
        {
        }

        public eWaiterTestContext(DbContextOptions<eWaiterTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<AgreementSupplier> AgreementSupplier { get; set; }
        public virtual DbSet<Allergy> Allergy { get; set; }
        public virtual DbSet<CreateOrderForIngredient> CreateOrderForIngredient { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerPaymentMethod> CustomerPaymentMethod { get; set; }
        public virtual DbSet<Facility> Facility { get; set; }
        public virtual DbSet<FoodType> FoodType { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<IngredientStockLevel> IngredientStockLevel { get; set; }
        public virtual DbSet<IngredientSupplier> IngredientSupplier { get; set; }
        public virtual DbSet<IngredientType> IngredientType { get; set; }
        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
        public virtual DbSet<ItemStatus> ItemStatus { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuItem> MenuItem { get; set; }
        public virtual DbSet<MenuItemAllergy> MenuItemAllergy { get; set; }
        public virtual DbSet<MenuItemIngredient> MenuItemIngredient { get; set; }
        public virtual DbSet<MenuItemPrice> MenuItemPrice { get; set; }
        public virtual DbSet<MenuItemSpecial> MenuItemSpecial { get; set; }
        public virtual DbSet<OrderComment> OrderComment { get; set; }
        public virtual DbSet<OrderMenuItem> OrderMenuItem { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderTable> OrderTable { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<PlacedOrder> PlacedOrder { get; set; }
        public virtual DbSet<PlannedShift> PlannedShift { get; set; }
        public virtual DbSet<ReorderFrequency> ReorderFrequency { get; set; }
        public virtual DbSet<Restaurant> Restaurant { get; set; }
        public virtual DbSet<RestaurantFacility> RestaurantFacility { get; set; }
        public virtual DbSet<RestaurantImg> RestaurantImg { get; set; }
        public virtual DbSet<RestaurantSeating> RestaurantSeating { get; set; }
        public virtual DbSet<RestaurantType> RestaurantType { get; set; }
        public virtual DbSet<RestaurantUserComment> RestaurantUserComment { get; set; }
        public virtual DbSet<Seating> Seating { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<Special> Special { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<StaffRole> StaffRole { get; set; }
        public virtual DbSet<StaffShift> StaffShift { get; set; }
        public virtual DbSet<StarRating> StarRating { get; set; }
        public virtual DbSet<StatusCatalog> StatusCatalog { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierAddress> SupplierAddress { get; set; }
        public virtual DbSet<SupplierAgreement> SupplierAgreement { get; set; }
        public virtual DbSet<UserTableBooking> UserTableBooking { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=eWaiterTest;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Line1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Line2)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AdvFile)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DateActiveFrom).HasColumnType("date");

                entity.Property(e => e.DateActiveTo).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TargetAudience).HasMaxLength(50);
            });

            modelBuilder.Entity<AgreementSupplier>(entity =>
            {
                entity.HasKey(e => new { e.SupplierAgreementId, e.SupplierId })
                    .HasName("PK__Agreemen__06F8FAC37DE6BEFD");

                entity.ToTable("Agreement_Supplier");

                entity.HasOne(d => d.SupplierAgreement)
                    .WithMany(p => p.AgreementSupplier)
                    .HasForeignKey(d => d.SupplierAgreementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agreement__Suppl__4D94879B");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.AgreementSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Agreement__Suppl__4E88ABD4");
            });

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CreateOrderForIngredient>(entity =>
            {
                entity.HasKey(e => e.IngredientId)
                    .HasName("PK__CreateOr__BEAEB25A292DB25C");

                entity.Property(e => e.IngredientId).ValueGeneratedNever();

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.HasOne(d => d.Ingredient)
                    .WithOne(p => p.CreateOrderForIngredient)
                    .HasForeignKey<CreateOrderForIngredient>(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CreateOrd__Ingre__5812160E");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConfirmationCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShareInfo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerPaymentMethod>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.PaymentMethodId, e.PlacedOrderId })
                    .HasName("PK__Customer__F6D493882BB0E075");

                entity.ToTable("Customer_PaymentMethod");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPaymentMethod)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer___Custo__32AB8735");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.CustomerPaymentMethod)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer___Payme__339FAB6E");

                entity.HasOne(d => d.PlacedOrder)
                    .WithMany(p => p.CustomerPaymentMethod)
                    .HasForeignKey(d => d.PlacedOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer___Place__3493CFA7");
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FoodType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StandardCost).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IngredientType)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.IngredientTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Ingre__5165187F");

                entity.HasOne(d => d.ReorderFreq)
                    .WithMany(p => p.Ingredient)
                    .HasForeignKey(d => d.ReorderFreqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Reord__52593CB8");
            });

            modelBuilder.Entity<IngredientStockLevel>(entity =>
            {
                entity.HasKey(e => e.IngredientId)
                    .HasName("PK__Ingredie__BEAEB25A74C4CBD8");

                entity.Property(e => e.IngredientId).ValueGeneratedNever();

                entity.Property(e => e.StockTackingDate).HasColumnType("date");

                entity.HasOne(d => d.Ingredient)
                    .WithOne(p => p.IngredientStockLevel)
                    .HasForeignKey<IngredientStockLevel>(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Ingre__5535A963");
            });

            modelBuilder.Entity<IngredientSupplier>(entity =>
            {
                entity.HasKey(e => new { e.IngredientId, e.SupplierId })
                    .HasName("PK__Ingredie__EA10D4316AD4BD68");

                entity.ToTable("Ingredient_Supplier");

                entity.Property(e => e.ValueSuppliedToDate).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.IngredientSupplier)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Ingre__5AEE82B9");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.IngredientSupplier)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ingredien__Suppl__5BE2A6F2");
            });

            modelBuilder.Entity<IngredientType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateActiveFrom).HasColumnType("datetime");

                entity.Property(e => e.DateActiveTo).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => new { e.RestaurantId, e.MenuItemId })
                    .HasName("PK__Menu__BFD173E7C243D299");

                entity.Property(e => e.DateActiveFrom).HasColumnType("date");

                entity.Property(e => e.DateActiveTo).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(60);

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menu__MenuItemId__114A936A");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Menu__Restaurant__10566F31");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ItemCategory)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.ItemCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem__ItemCa__5EBF139D");

                entity.HasOne(d => d.ItemStatus)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.ItemStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem__ItemSt__60A75C0F");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem__ItemTy__5FB337D6");
            });

            modelBuilder.Entity<MenuItemAllergy>(entity =>
            {
                entity.HasKey(e => new { e.MenuItemId, e.AllergyId })
                    .HasName("PK__MenuItem__B30A1CC6B138A81E");

                entity.ToTable("MenuItem_Allergy");

                entity.HasOne(d => d.Allergy)
                    .WithMany(p => p.MenuItemAllergy)
                    .HasForeignKey(d => d.AllergyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___Aller__6477ECF3");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.MenuItemAllergy)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___MenuI__6383C8BA");
            });

            modelBuilder.Entity<MenuItemIngredient>(entity =>
            {
                entity.HasKey(e => new { e.IngredientId, e.MenuItemId })
                    .HasName("PK__MenuItem__863A8D28B8817D6A");

                entity.ToTable("MenuItem_Ingredient");

                entity.HasOne(d => d.Ingredient)
                    .WithMany(p => p.MenuItemIngredient)
                    .HasForeignKey(d => d.IngredientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___Ingre__6754599E");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.MenuItemIngredient)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___MenuI__68487DD7");
            });

            modelBuilder.Entity<MenuItemPrice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.MenuItemPrice)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItemP__MenuI__6B24EA82");
            });

            modelBuilder.Entity<MenuItemSpecial>(entity =>
            {
                entity.HasKey(e => new { e.SpecialId, e.MenuItemId })
                    .HasName("PK__MenuItem__13CAFD120F580619");

                entity.ToTable("MenuItem_SPecial");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.MenuItemSpecial)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___MenuI__70DDC3D8");

                entity.HasOne(d => d.Special)
                    .WithMany(p => p.MenuItemSpecial)
                    .HasForeignKey(d => d.SpecialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MenuItem___Speci__6FE99F9F");
            });

            modelBuilder.Entity<OrderComment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ComlplaintYn)
                    .IsRequired()
                    .HasColumnName("Comlplaint_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.CommentDateTime).HasColumnType("datetime");

                entity.Property(e => e.CommentText)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PlacedOrder)
                    .WithMany(p => p.OrderComment)
                    .HasForeignKey(d => d.PlacedOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderComm__Place__2FCF1A8A");
            });

            modelBuilder.Entity<OrderMenuItem>(entity =>
            {
                entity.HasKey(e => new { e.PlacedOrderId, e.MenuItemId })
                    .HasName("PK__Order_Me__817F720C5794C1A1");

                entity.ToTable("Order_MenuItem");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FinalTotal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StaffTip).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Vatamount)
                    .HasColumnName("VATamount")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MenuItem)
                    .WithMany(p => p.OrderMenuItem)
                    .HasForeignKey(d => d.MenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Men__MenuI__3C34F16F");

                entity.HasOne(d => d.PlacedOrder)
                    .WithMany(p => p.OrderMenuItem)
                    .HasForeignKey(d => d.PlacedOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Men__Place__3B40CD36");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.HasKey(e => new { e.PlacedOrderId, e.StatusCatalogId })
                    .HasName("PK__Order_St__4032B12161AC722B");

                entity.ToTable("Order_Status");

                entity.Property(e => e.DateChanged).HasColumnType("datetime");

                entity.HasOne(d => d.PlacedOrder)
                    .WithMany(p => p.OrderStatus)
                    .HasForeignKey(d => d.PlacedOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Sta__Place__37703C52");

                entity.HasOne(d => d.StatusCatalog)
                    .WithMany(p => p.OrderStatus)
                    .HasForeignKey(d => d.StatusCatalogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Sta__Statu__3864608B");
            });

            modelBuilder.Entity<OrderTable>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BillSplitYn)
                    .IsRequired()
                    .HasColumnName("BillSplit_YN")
                    .HasMaxLength(6);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PlacedOrder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.OrderTable)
                    .WithMany(p => p.PlacedOrder)
                    .HasForeignKey(d => d.OrderTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlacedOrd__Order__2BFE89A6");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.PlacedOrder)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlacedOrd__Staff__2CF2ADDF");
            });

            modelBuilder.Entity<PlannedShift>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReorderFrequency>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Restaurant>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SocialMediaAddress).HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Addre__7B5B524B");

                entity.HasOne(d => d.Advertisement)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.AdvertisementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Adver__797309D9");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Restaurant)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Image__7A672E12");
            });

            modelBuilder.Entity<RestaurantFacility>(entity =>
            {
                entity.HasKey(e => new { e.RestaurantId, e.FacilityId })
                    .HasName("PK__Restaura__D2BE443264465536");

                entity.ToTable("Restaurant_Facility");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.RestaurantFacility)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Facil__07C12930");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantFacility)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Resta__06CD04F7");
            });

            modelBuilder.Entity<RestaurantImg>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageFile)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<RestaurantSeating>(entity =>
            {
                entity.HasKey(e => new { e.RestaurantId, e.SeatingId })
                    .HasName("PK__Restaura__47B34312FE83E94C");

                entity.ToTable("Restaurant_Seating");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantSeating)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Resta__02FC7413");

                entity.HasOne(d => d.Seating)
                    .WithMany(p => p.RestaurantSeating)
                    .HasForeignKey(d => d.SeatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Seati__03F0984C");
            });

            modelBuilder.Entity<RestaurantType>(entity =>
            {
                entity.HasKey(e => new { e.RestaurantId, e.FoodTypeId })
                    .HasName("PK__Restaura__5A7859DD2231030F");

                entity.HasOne(d => d.FoodType)
                    .WithMany(p => p.RestaurantType)
                    .HasForeignKey(d => d.FoodTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__FoodT__0D7A0286");

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.RestaurantType)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Resta__0C85DE4D");
            });

            modelBuilder.Entity<RestaurantUserComment>(entity =>
            {
                entity.ToTable("Restaurant_User_Comment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.CommentText)
                    .IsRequired()
                    .HasMaxLength(140);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RestaurantUserComment)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__Custo__40F9A68C");

                entity.HasOne(d => d.StarRating)
                    .WithMany(p => p.RestaurantUserComment)
                    .HasForeignKey(d => d.StarRatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Restauran__StarR__41EDCAC5");
            });

            modelBuilder.Entity<Seating>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.PlannedShift)
                    .WithMany(p => p.Shift)
                    .HasForeignKey(d => d.PlannedShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Shift__PlannedSh__160F4887");
            });

            modelBuilder.Entity<Special>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateActiveFrom).HasColumnType("date");

                entity.Property(e => e.DateActiveTo).HasColumnType("date");

                entity.Property(e => e.SpecialPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IdNumber).HasMaxLength(13);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.HasOne(d => d.Restaurant)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.RestaurantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff__Restauran__1BC821DD");

                entity.HasOne(d => d.StaffRole)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.StaffRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff__StaffRole__1AD3FDA4");
            });

            modelBuilder.Entity<StaffRole>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HourlyRate).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<StaffShift>(entity =>
            {
                entity.HasKey(e => new { e.StaffId, e.ShiftId })
                    .HasName("PK__Staff_Sh__9ADE289FFB97308C");

                entity.ToTable("Staff_Shift");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.StaffShift)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff_Shi__Shift__1EA48E88");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.StaffShift)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Staff_Shi__Staff__1F98B2C1");
            });

            modelBuilder.Entity<StarRating>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<StatusCatalog>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContactNr).HasMaxLength(13);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNr).HasMaxLength(13);

                entity.Property(e => e.TaxNr)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SupplierAddress>(entity =>
            {
                entity.HasKey(e => new { e.SupplierId, e.AddressTypeId, e.AddressId })
                    .HasName("PK__Supplier__B9502C5CCD9CB7FC");

                entity.ToTable("Supplier_Address");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.SupplierAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplier___Addre__00200768");

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.SupplierAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplier___Addre__7F2BE32F");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierAddress)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Supplier___Suppl__7E37BEF6");
            });

            modelBuilder.Entity<SupplierAgreement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DiscountAgreement).HasMaxLength(140);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StandardPrice).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<UserTableBooking>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.OrderTableId })
                    .HasName("PK__User_Tab__8B2003CB811F5C4D");

                entity.ToTable("User_Table_Booking");

                entity.Property(e => e.DateBookingMade).HasColumnType("datetime");

                entity.Property(e => e.DateTableBookedFor).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.UserTableBooking)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Tabl__Custo__282DF8C2");

                entity.HasOne(d => d.OrderTable)
                    .WithMany(p => p.UserTableBooking)
                    .HasForeignKey(d => d.OrderTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Tabl__Order__29221CFB");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
