using System.Collections.Generic;
using Inventory;
using ScriptableObject.Shop;
using UnityEngine;

namespace Shop
{
    public class Shop : MonoBehaviour
    {
        [SerializeField] private InventoryItemManager inventoryItemManager;
        [SerializeField] public List<ShopItem> shopItemsList = new List<ShopItem>();
        [SerializeField] private GameObject shopScrollList;
        private ShopItemProvider _shopItemProvider;

        private void Awake()
        {
            _shopItemProvider = GetComponent<ShopItemProvider>();
        }

        private void Start()
        {
            LoadItems();
        }

        private void ButtonBuyClick(ShopItem shopItem)
        {
            print($"Click button id: {shopItem.id}");
            inventoryItemManager.AddInventoryItem(shopItem);
        }

        private void LoadItems()
        {
            if (shopItemsList.Count == 0) return;
            foreach (var item in shopItemsList)
            {
                var prefab = _shopItemProvider.GetItemData(item.shopItemType);
                if (prefab == null) continue;
                var baseShopItem = Instantiate(prefab, shopScrollList.transform);
                baseShopItem.Initialize(item, ButtonBuyClick);
            }
        }
    }
}