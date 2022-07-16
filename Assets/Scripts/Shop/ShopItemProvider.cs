using System.Collections.Generic;
using ScriptableObject.Shop;
using Shop.ShopItems;
using UnityEngine;

namespace Shop
{
    public class ShopItemProvider : MonoBehaviour
    {
        private readonly Dictionary<ShopItem.ShopItemType, BaseShopItem> _listPrefabs =
            new Dictionary<ShopItem.ShopItemType, BaseShopItem>();

        private void Awake()
        {
            _listPrefabs.Add(ShopItem.ShopItemType.Normal, Resources.Load<BaseShopItem>("Prefabs/Shop/itemNormal"));
            _listPrefabs.Add(ShopItem.ShopItemType.Discount, Resources.Load<BaseShopItem>("Prefabs/Shop/itemDiscount"));
        }

        public BaseShopItem GetItemData(ShopItem.ShopItemType shopItemType)
        {
            _listPrefabs.TryGetValue(shopItemType, out var value);
            return value;
        }
    }
}