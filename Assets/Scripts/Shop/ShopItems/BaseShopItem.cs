using ScriptableObject;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Shop.ShopItems
{
	public abstract class BaseShopItem : MonoBehaviour
	{
		public Image icon;
		public TextMeshProUGUI title;
		public TextMeshProUGUI description;
		public TextMeshProUGUI weight;
		public TextMeshProUGUI cost;
		public Button button;
		public int id; 
		public abstract void Initialize(Item item);
	}
}