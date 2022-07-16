using System;
using System.Globalization;
using ScriptableObject.Shop;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Shop.ShopItems
{
    public abstract class BaseShopItem : MonoBehaviour
    {
        public Image icon;
        public Image background;
        public GameObject sale;
        public TextMeshProUGUI title;
        public TextMeshProUGUI description;
        public TextMeshProUGUI weight;
        public TextMeshProUGUI cost;
        public Button button;

        public virtual void Initialize(ShopItem shopItem, Action<ShopItem> action)
        {
            icon.sprite = shopItem.icon;
            title.text = shopItem.title;
            description.text = shopItem.description;
            cost.text = shopItem.cost.ToString(CultureInfo.InvariantCulture);
            weight.text = $"{shopItem.weight.ToString(CultureInfo.InvariantCulture)}kg";
            button.onClick.AddListener(() =>
            {
                SetStatusPurchased();
                action(shopItem);
            });
        }

        protected virtual void SetStatusPurchased()
        {
            cost.text = $"Purchased";
            cost.fontSize = 50;
            background.color = icon.color = new Color(0.5f, 0.5f, 0.5f);
            button.interactable = false;
        }
    }
}