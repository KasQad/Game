using UnityEngine;

namespace ScriptableObject
{
	[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Item", order = 1)]
	public class Item : UnityEngine.ScriptableObject
	{
		public enum TypeItem
		{
			Normal,
			Discount,
			NotForSale
		}

		public Sprite sprite;
		public string title;
		public string description;
		public float weight;
		public float cost;
		public TypeItem typeItem;
		public float discount;
	}
}