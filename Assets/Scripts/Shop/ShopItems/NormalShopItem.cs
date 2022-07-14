using ScriptableObject;
using UnityEngine;

namespace Shop.ShopItems
{
	public class NormalShopItem : BaseShopItem
	{
		public override void Initialize(Item item)
		{
			icon.sprite = item.sprite;
			title.text = item.title;
			description.text = item.description;
			cost.text = item.cost.ToString();
			weight.text = item.weight.ToString() + "kg";
			id = Random.Range(0, 10000);
			button.onClick.AddListener(() => { print($"Click button: {item.title} | id: {id}"); });
			Debug.Log("NormalShopItem : BaseShopItem");
		}
	}
}