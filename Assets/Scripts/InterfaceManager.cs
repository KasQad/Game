using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager: MonoBehaviour
{
    [SerializeField] private Button buttonShop;
    [SerializeField] private Button buttonInventory;
    
    [SerializeField] private GameObject shopView;
    [SerializeField] private GameObject inventoryView;

    private readonly Dictionary<Button, GameObject> _listViews = new Dictionary<Button, GameObject>();

    private void Awake()
    {
        _listViews.Add(buttonShop, shopView);
        _listViews.Add(buttonInventory, inventoryView);

        buttonShop.onClick.AddListener(() => ChangeView(buttonShop));
        buttonInventory.onClick.AddListener(() => ChangeView(buttonInventory));
    }

    private void ChangeView(Button button)
    {
        foreach (var view in _listViews)
            view.Value.SetActive(view.Key.Equals(button));
    }
}