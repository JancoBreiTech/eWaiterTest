using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public interface IRepositoryWrapper
    {
        IAddress Address { get; }
        IAddressType AddressType { get; }
        IAdvertisement Advertisement { get; }
        IAgreementSupplier AgreementSupplier { get;}
        IAllergy Allergy { get;}
        ICreateOrderForIngredient CreateOrderForIngredient { get;}
        ICustomer Customer { get; }
        ICustomerPaymentMethod CustomerPaymentMethod { get; }
        IFacility Facility { get; }
        IFoodType FoodType { get; }
        IIngredient Ingredient { get; }
        IIngredientStockLevel IngredientStockLevel { get; }
        IIngredientSupplier IngredientSupplier { get; }
        IIngredientType IngredientType { get; }
        IItemCategory ItemCategory { get; }
        IItemStatus ItemStatus { get; }
        IItemType ItemType { get;}
        IMenu Menu { get; }
        IMenuItem MenuItem { get; }
        IMenuItemAllergy MenuItemAllergy { get; }
        IMenuItemIngredient MenuItemIngredient { get; }
        IMenuItemPrice MenuItemPrice { get;}
        IMenuItemSpecial MenuItemSpecial { get;}
        IOrderComment OrderComment { get;}
        IOrderMenuItem OrderMenuItem { get;}
        IOrderStatus OrderStatus { get;}
        IOrderTable OrderTable { get;}
        IPaymentMethod PaymentMethod { get;}
        IPlacedOrder PlacedOrder { get;}
        IPlannedShift PlannedShift { get;}
        IReorderFrequency ReorderFrequency { get;}
        IRestaurant Restaurant { get;}
        IRestaurantFacility RestaurantFacility { get; }
        IRestaurantImg RestaurantImg { get; }
        IRestaurantSeating RestaurantSeating { get; }
        IRestaurantType RestaurantType { get; }
        IRestaurantUserComment RestaurantUserComment { get;  }
        ISeating Seating { get; }
        IShift Shift { get; }
        ISpecial Special { get;  }
        IStaff Staff { get; }
        IStaffRole StaffRole { get; }
        IStaffShift StaffShift { get; }
        IStarRating StarRating { get; }
        IStatusCatalog StatusCatalog { get; }
        ISupplier Supplier { get; }
        ISupplierAddress SupplierAddress { get; }
        ISupplierAgreement SupplierAgreement { get; }
        IUserTableBooking UserTableBooking { get; }
        void Save();
    }
}
