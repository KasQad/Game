using Inventory.InventoryItems;
using ScriptableObject.Inventory;
using UnityEngine;

namespace Inventory
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private GameObject inventoryScrollList;
        [SerializeField] private InventoryItemManager inventoryItemManager;

        private void Start()
        {
            LoadItems();
        }

        private void ButtonItemClick(InventoryItem inventoryItem)
        {
            print($"count: {++inventoryItem.count}");
        }

        public void LoadItems()
        {
            DestroyItems();
            if (inventoryItemManager.inventoryItemsList.Count == 0) return;
            var prefab = Resources.Load<BaseInventoryItem>("Prefabs/Inventory/InventoryItem");
            foreach (var item in inventoryItemManager.inventoryItemsList)
            {
                var inventoryItem = Instantiate(prefab, inventoryScrollList.transform);
                inventoryItem.Initialize(item, ButtonItemClick);
            }
        }

        private void DestroyItems()
        {
            var father = inventoryScrollList.transform;
            for (var i = 0; i < father.childCount; i++)
                Destroy(father.GetChild(i).gameObject);
        }
    }
}