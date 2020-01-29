using Contracts;
using Contracts.MenuItemInterfaces;
using Entities.Models;
using Repository.MenuItemRepoClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private eWaiterTestContext _repoContext;
        private IMenuItem _menuItem;
        private IItemType _itemType;
        private IItemStatus _itemStatus;
        private IItemCategory _itemCategory;
        public IMenuItem MenuItem
        {
            get
            {
                if (_menuItem == null)
                {
                    _menuItem = new MenuItemRepository(_repoContext);
                }

                return _menuItem;
            }
        }

        public IItemType ItemType
        {
            get
            {
                if (_itemType == null)
                {
                    _itemType = new ItemTypeRepository(_repoContext);
                }

                return _itemType;
            }
        }

        public IItemCategory ItemCategory
        {
            get
            {
                if (_itemCategory == null)
                {
                    _itemCategory = new ItemCategoryRepository(_repoContext);
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
                    _itemStatus = new ItemStatusRepository(_repoContext);
                }

                return _itemStatus;
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
