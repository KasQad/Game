using System.Collections.Generic;
using ScriptableObject.Inventory;
using ScriptableObject.Shop;
using UnityEngine;

namespace Inventory
{
    public class InventoryItemManager : MonoBehaviour
    {
        [SerializeField] private InventoryView inventoryView;
        public List<InventoryItem> inventoryItemsList = new List<InventoryItem>();

        public void AddInventoryItem(ShopItem shopItem)
        {
            print($"AddInventoryItem: {shopItem.title}");
            inventoryItemsList.Add(ConvertShopItemToInventoryItem(shopItem));
            inventoryView.LoadItems();
        }

        private InventoryItem ConvertShopItemToInventoryItem(ShopItem shopItem)
        {
            return new InventoryItem() { icon = shopItem.icon, title = shopItem.title, count = 1 };
        }
    }
}