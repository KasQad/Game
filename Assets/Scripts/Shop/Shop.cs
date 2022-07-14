using System.Collections.Generic;
using ScriptableObject;
using UnityEngine;

namespace Shop
{
	public class Shop : MonoBehaviour
	{
		[SerializeField] private List<Item> listItems = new List<Item>();
		[SerializeField] private GameObject scrollList;
		private ShopItemProvider _shopItemProvider;

		private void Awake()
		{
			_shopItemProvider = gameObject.GetComponent<ShopItemProvider>();
		}

		private void Start()
		{
			LoadItems();
		}

		private void LoadItems()
		{
			foreach (var item in listItems)
			{
				var prefab = _shopItemProvider.GetItemData(item.typeItem);
				var go = Instantiate(prefab, scrollList.transform);
				go.Initialize(item);
			}
		}
	}
}