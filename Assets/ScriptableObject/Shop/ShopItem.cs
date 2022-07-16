using UnityEngine;

namespace ScriptableObject.Shop
{
    [CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Shop/ShopItem", order = 1)]
    public class ShopItem : UnityEngine.ScriptableObject
    {
        public enum ShopItemType
        {
            Normal,
            Discount
        }

        public Sprite icon;
        public string title;
        public string description;
        public float weight;
        public float cost;
        public ShopItemType shopItemType;
        public float discount;
        public int id;
    }
}