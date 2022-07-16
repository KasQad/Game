using UnityEngine;

namespace ScriptableObject.Inventory
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Inventory/InventoryItem", order = 1)]
    public class InventoryItem : UnityEngine.ScriptableObject
    {
        public Sprite icon;
        public string title;
        public int count;
    }
}