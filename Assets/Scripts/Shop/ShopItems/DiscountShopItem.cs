using ScriptableObject;
using TMPro;
using UnityEngine;

namespace Shop.ShopItems
{
	public class DiscountShopItem : BaseShopItem
	{
		public TextMeshProUGUI discount;
		public override void Initialize(Item item)
		{
			icon.sprite = item.sprite;
			title.text = item.title;
			description.text = item.description;
			cost.text = item.cost.ToString();
			weight.text=item.weight.ToString()+"kg";
			discount.text = "-"+item.discount.ToString()+"%";
			id = Random.Range(0, 10000);
			button.onClick.AddListener(() => { print($"Click button: {item.title} | id: {id}"); });
			Debug.Log($"DiscountShopItem : BaseShopItem");
		}
	}
}