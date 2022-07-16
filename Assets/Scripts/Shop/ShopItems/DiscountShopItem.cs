using System;
using ScriptableObject.Shop;
using TMPro;

namespace Shop.ShopItems
{
    public class DiscountShopItem : BaseShopItem
    {
        public TextMeshProUGUI discount;

        public override void Initialize(ShopItem shopItem, Action<ShopItem> action)
        {
            base.Initialize(shopItem, action);
            discount.text = $"-{shopItem.discount}%";
        }

        protected override void SetStatusPurchased()
        {
            base.SetStatusPurchased();
            discount.text = $"";
            sale.SetActive(false);
        }
    }
}