using Entities.Models;
using Entities.Repository;
using Entities.Repository.RepoClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class RepositoryWrapper: IRepositoryWrapper
    {
        private eWaiterTestContext _repoContext;
        private IAddress _address;
        private IAddressType _addressType;
        private IAdvertisement _advertisement;
        private IAgreementSupplier _agreementSupplier;
        private IAllergy _allergy;
        private ICreateOrderForIngredient _createOrderForIngredient;
        private ICustomer _customer;
        private ICustomerPaymentMethod _customerPaymentMethod;
        private IFacility _facility;
        private IFoodType _foodType;
        private IIngredient _ingredient;
        private IIngredientStockLevel _ingredientStockLevel;
        private IIngredientSupplier _ingredientSupplier;
        private IIngredientType _ingredientType;
        private IItemCategory _itemCategory;
        private IItemStatus _itemStatus;
        private IItemType _itemType;
        private IMenu _menu;
        private IMenuItem _menuItem;
        private IMenuItemAllergy _menuItemAllergy;
        private IMenuItemIngredient _menuItemIngredient;
        private IMenuItemPrice _menuItemPrice;
        private IMenuItemSpecial _menuItemSpecial;
        private IOrderComment _orderComment;
        private IOrderMenuItem _orderMenuItem;
        private IOrderStatus _orderStatus;
        private IOrderTable _orderTable;
        private IPaymentMethod _paymentMethod;
        private IPlacedOrder _placedOrder;
        private IPlannedShift _plannedShift;
        private IReorderFrequency _reorderFrequency;
        private IRestaurant _restaurant;
        private IRestaurantFacility _restaurantFacility;
        private IRestaurantImg _restaurantImg;
        private IRestaurantSeating _restaurantSeating;
        private IRestaurantType _restaurantType;
        private IRestaurantUserComment _restaurantUserComment;
        private ISeating _seating;
        private IShift _shift;
        private ISpecial _special;
        private IStaff _staff;
        private IStaffRole _staffRole;
        private IStaffShift _staffShift;
        private IStarRating _starRating;
        private IStatusCatalog _statusCatalog;
        private ISupplier _supplier;
        private ISupplierAddress _supplierAddress;
        private ISupplierAgreement _supplierAgreement;
        private IUserTableBooking _userTableBooking;

        public IAddress Address
        {
            get
            {
                if (_address == null)
                {
                    _address = new AddressRepo(_repoContext);
                }

                return _address;
            }
        }

        public IAddressType AddressType
        {
            get
            {
                if (_addressType == null)
                {
                    _addressType = new AddressTypeRepo(_repoContext);
                }

                return _addressType;
            }
        }
        public IAdvertisement Advertisement
        {
            get
            {
                if (_advertisement == null)
                {
                    _advertisement = new AdvertisementRepo(_repoContext);
                }

                return _advertisement;
            }
        }

        public IAgreementSupplier AgreementSupplier
        {
            get
            {
                if (_agreementSupplier == null)
                {
                    _agreementSupplier = new AgreementSupplierRepo(_repoContext);
                }

                return _agreementSupplier;
            }
        }

        public IAllergy Allergy
        {
            get
            {
                if (_allergy == null)
                {
                    _allergy = new AllergyRepo(_repoContext);
                }

                return _allergy;
            }
        }

        public ICreateOrderForIngredient CreateOrderForIngredient
        {
            get
            {
                if (_createOrderForIngredient == null)
                {
                    _createOrderForIngredient = new CreateOrderForIngredientRepo(_repoContext);
                }

                return _createOrderForIngredient;
            }
        }

        public ICustomer Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new CustomerRepo(_repoContext);
                }

                return _customer;
            }
        }

        public ICustomerPaymentMethod CustomerPaymentMethod
        {
            get
            {
                if (_customerPaymentMethod == null)
                {
                    _customerPaymentMethod = new CustomerPaymentMethodRepo(_repoContext);
                }

                return _customerPaymentMethod;
            }
        }

        public IFacility Facility
        {
            get
            {
                if (_facility == null)
                {
                    _facility = new FacilityRepo(_repoContext);
                }

                return _facility;
            }
        }

        public IFoodType FoodType
        {
            get
            {
                if (_foodType == null)
                {
                    _foodType = new FoodTypeRepo(_repoContext);
                }

                return _foodType;
            }
        }

        public IIngredient Ingredient
        {
            get
            {
                if (_ingredient == null)
                {
                    _ingredient = new IngredientRepo(_repoContext);
                }

                return _ingredient;
            }
        }

        public IIngredientStockLevel IngredientStockLevel
        {
            get
            {
                if (_ingredientStockLevel == null)
                {
                    _ingredientStockLevel = new IngredientStockLevelRepo(_repoContext);
                }

                return _ingredientStockLevel;
            }
        }

        public IIngredientSupplier IngredientSupplier
        {
            get
            {
                if (_ingredientSupplier == null)
                {
                    _ingredientSupplier = new IngredientSupplierRepo(_repoContext);
                }

                return _ingredientSupplier;
            }
        }

        public IIngredientType IngredientType
        {
            get
            {
                if (_ingredientType == null)
                {
                    _ingredientType = new IngredientTypeRepo(_repoContext);
                }

                return _ingredientType;
            }
        }

        public IMenu Menu
        {
            get
            {
                if (_menu == null)
                {
                    _menu = new MenuRepo(_repoContext);
                }

                return _menu;
            }
        }

        public IMenuItem MenuItem
        {
            get
            {
                if (_menuItem == null)
                {
                    _menuItem = new MenuItemRepo(_repoContext);
                }

                return _menuItem;
            }
        }

        public IMenuItemAllergy MenuItemAllergy
        {
            get
            {
                if (_menuItemAllergy == null)
                {
                    _menuItemAllergy = new MenuItemAllergyRepo(_repoContext);
                }

                return _menuItemAllergy;
            }
        }

        public IMenuItemIngredient MenuItemIngredient
        {
            get
            {
                if (_menuItemIngredient == null)
                {
                    _menuItemIngredient = new MenuItemIngredientRepo(_repoContext);
                }

                return _menuItemIngredient;
            }
        }

        public IRestaurant Restaurant
        {
            get
            {
                if (_restaurant == null)
                {
                    _restaurant = new RestaurantRepo(_repoContext);
                }

                return _restaurant;
            }
        }

        public IMenuItemPrice MenuItemPrice
        {
            get
            {
                if (_menuItemPrice == null)
                {
                    _menuItemPrice = new MenuItemPriceRepo(_repoContext);
                }

                return _menuItemPrice;
            }
        }

        public IMenuItemSpecial MenuItemSpecial
        {
            get
            {
                if (_menuItemSpecial == null)
                {
                    _menuItemSpecial = new MenuItemSpecialRepo(_repoContext);
                }

                return _menuItemSpecial;
            }
        }

        public IOrderComment OrderComment
        {
            get
            {
                if (_orderComment == null)
                {
                    _orderComment = new OrderCommentRepo(_repoContext);
                }

                return _orderComment;
            }
        }

        public IOrderMenuItem OrderMenuItem
        {
            get
            {
                if (_orderMenuItem == null)
                {
                    _orderMenuItem = new OrderMenuItemRepo(_repoContext);
                }

                return _orderMenuItem;
            }
        }

        public IOrderStatus OrderStatus
        {
            get
            {
                if (_orderStatus == null)
                {
                    _orderStatus = new OrderStatusRepo(_repoContext);
                }

                return _orderStatus;
            }
        }

        public IOrderTable OrderTable
        {
            get
            {
                if (_orderTable == null)
                {
                    _orderTable = new OrderTableRepo(_repoContext);
                }

                return _orderTable;
            }
        }

        public IPaymentMethod PaymentMethod
        {
            get
            {
                if (_paymentMethod == null)
                {
                    _paymentMethod = new PaymentMethodRepo(_repoContext);
                }

                return _paymentMethod;
            }
        }

        public IReorderFrequency ReorderFrequency
        {
            get
            {
                if (_reorderFrequency == null)
                {
                    _reorderFrequency = new ReorderFrequencyRepo(_repoContext);
                }

                return _reorderFrequency;
            }
        }

        public IPlacedOrder PlacedOrder
        {
            get
            {
                if (_placedOrder == null)
                {
                    _placedOrder = new PlacedOrderRepo(_repoContext);
                }

                return _placedOrder;
            }
        }

        public IPlannedShift PlannedShift
        {
            get
            {
                if (_plannedShift == null)
                {
                    _plannedShift = new PlannedShiftRepo(_repoContext);
                }

                return _plannedShift;
            }
        }

        public IRestaurantFacility RestaurantFacility
        {
            get
            {
                if (_restaurantFacility == null)
                {
                    _restaurantFacility = new RestaurantFacilityRepo(_repoContext);
                }

                return _restaurantFacility;
            }
        }

        public IRestaurantImg RestaurantImg
        {
            get
            {
                if (_restaurantImg == null)
                {
                    _restaurantImg = new RestaurantImgRepo(_repoContext);
                }

                return _restaurantImg;
            }
        }

        public IRestaurantSeating RestaurantSeating
        {
            get
            {
                if (_restaurantSeating == null)
                {
                    _restaurantSeating = new RestaurantSeatingRepo(_repoContext);
                }

                return _restaurantSeating;
            }
        }

        public IRestaurantType RestaurantType
        {
            get
            {
                if (_restaurantType == null)
                {
                    _restaurantType = new RestaurantTypeRepo(_repoContext);
                }

                return _restaurantType;
            }
        }

        public IRestaurantUserComment RestaurantUserComment
        {
            get
            {
                if (_restaurantUserComment == null)
                {
                    _restaurantUserComment = new RestaurantUserCommentRepo(_repoContext);
                }

                return _restaurantUserComment;
            }
        }

        public IShift Shift
        {
            get
            {
                if (_shift == null)
                {
                    _shift = new ShiftRepo(_repoContext);
                }

                return _shift;
            }
        }

        public ISeating Seating
        {
            get
            {
                if (_seating == null)
                {
                    _seating = new SeatingRepo(_repoContext);
                }

                return _seating;
            }
        }

        public ISpecial Special
        {
            get
            {
                if (_special == null)
                {
                    _special = new SpecialRepo(_repoContext);
                }

                return _special;
            }
        }

        public IStaff Staff
        {
            get
            {
                if (_staff == null)
                {
                    _staff = new StaffRepo(_repoContext);
                }

                return _staff;
            }
        }

        public IStaffRole StaffRole
        {
            get
            {
                if (_staffRole == null)
                {
                    _staffRole = new StaffRoleRepo(_repoContext);
                }

                return _staffRole;
            }
        }

        public IStaffShift StaffShift
        {
            get
            {
                if (_staffShift == null)
                {
                    _staffShift = new StaffShiftRepo(_repoContext);
                }

                return _staffShift;
            }
        }

        public IStatusCatalog StatusCatalog
        {
            get
            {
                if (_statusCatalog == null)
                {
                    _statusCatalog = new StatusCatalogRepo(_repoContext);
                }

                return _statusCatalog;
            }
        }

        public IStarRating StarRating
        {
            get
            {
                if (_starRating == null)
                {
                    _starRating = new StarRatingRepo(_repoContext);
                }

                return _starRating;
            }
        }

        public ISupplier Supplier
        {
            get
            {
                if (_supplier == null)
                {
                    _supplier = new SupplierRepo(_repoContext);
                }

                return _supplier;
            }
        }

        public ISupplierAddress SupplierAddress
        {
            get
            {
                if (_supplierAddress == null)
                {
                    _supplierAddress = new SupplierAddressRepo(_repoContext);
                }

                return _supplierAddress;
            }
        }

        public ISupplierAgreement SupplierAgreement
        {
            get
            {
                if (_supplierAgreement == null)
                {
                    _supplierAgreement = new SupplierAgreementRepo(_repoContext);
                }

                return _supplierAgreement;
            }
        }

        public IUserTableBooking UserTableBooking
        {
            get
            {
                if (_userTableBooking == null)
                {
                    _userTableBooking = new UserTableBookingRepo(_repoContext);
                }

                return _userTableBooking;
            }
        }

        public IItemCategory ItemCategory
        {
            get
            {
                if (_itemCategory == null)
                {
                    _itemCategory = new ItemCategoryRepo(_repoContext);
                }

                return _itemCategory;
            }
        }

        public IItemStatus ItemStatus
        {
            get
            {
                if (_itemStatus == null)
                {
                    _itemStatus = new ItemStatusRepo(_repoContext);
                }

                return _itemStatus;
            }
        }

        public IItemType ItemType
        {
            get
            {
                if (_itemType == null)
                {
                    _itemType = new ItemTypeRepo(_repoContext);
                }

                return _itemType;
            }
        }


        public RepositoryWrapper(eWaiterTestContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
