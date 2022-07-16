using System;
using System.Globalization;
using ScriptableObject.Inventory;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory.InventoryItems
{
    public abstract class BaseInventoryItem : MonoBehaviour
    {
        public Image icon;
        public TextMeshProUGUI title;
        public TextMeshProUGUI count;
        public Button button;

        public void Initialize(InventoryItem inventoryItem, Action<InventoryItem> action)
        {
            icon.sprite = inventoryItem.icon;
            title.text = inventoryItem.title;
            count.text = inventoryItem.count.ToString(CultureInfo.InvariantCulture);

            button.onClick.AddListener(() =>
            {
                action(inventoryItem);
                ReDraw(inventoryItem);
            });
        }

        private void ReDraw(InventoryItem inventoryItem)
        {
            count.text = inventoryItem.count.ToString(CultureInfo.InvariantCulture);
        }
    }
}