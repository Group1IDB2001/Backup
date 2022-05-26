﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveLogic.CollectionItems
{
    public interface ICollectionItemManager
    {
        Task AddCollectionItem(int? collectionId, int? itemId);

        Task<IList<CollectionItem>> GetAllCollectionItem();
        Task DeleteCollectionItem(int collectionId, int itemId);
        Task<IList<CollectionItem>> GetItemCollectionByCollection (int collectionId);
        Task<IList<CollectionItem>> GetItemCollectionByItem(int itemId);
    }
}
