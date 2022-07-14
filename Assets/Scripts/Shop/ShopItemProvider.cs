using System.Collections.Generic;
using ScriptableObject;
using Shop.ShopItems;
using UnityEngine;

namespace Shop
{
	public class ShopItemProvider : MonoBehaviour
	{
		private readonly Dictionary<Item.TypeItem, BaseShopItem> _listPrefabs =
			new Dictionary<Item.TypeItem, BaseShopItem>();

		private void Awake()
		{
			_listPrefabs.Add(Item.TypeItem.Normal, Resources.Load<BaseShopItem>("Prefabs/itemNormal"));
			_listPrefabs.Add(Item.TypeItem.Discount, Resources.Load<BaseShopItem>("Prefabs/itemDescount"));
			_listPrefabs.Add(Item.TypeItem.NotForSale, Resources.Load<BaseShopItem>("Prefabs/itemNotForSale"));
		}

		public BaseShopItem GetItemData(Item.TypeItem typeItem)
		{
			_listPrefabs.TryGetValue(typeItem, out var value);
			return value;
		}
	}
}