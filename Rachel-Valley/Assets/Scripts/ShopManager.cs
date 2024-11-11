using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public GameObject[] items;
    public TextMeshProUGUI coinsText;
    private InventoryManager inventoryManager;

    void Start()
    {
        UpdateCoinsUI();
        inventoryManager = FindObjectOfType<InventoryManager>();
    }

    void Update()
    {
        UpdateCoinsUI();
    }

    void UpdateCoinsUI()
    {
        coinsText.text = "Coins: " + GameManager.Instance.coins;
    }

    public void PurchaseItem(int itemIndex)
    {
        if (itemIndex >= 0 && itemIndex < items.Length)
        {
            Item item = items[itemIndex].GetComponent<Item>();
            if (item != null && !item.isPurchased)
            {
                item.PurchaseItem();
                inventoryManager.purchasedItems.Add(item);
            }
        }
    }

    public void EquipItem(int itemIndex)
    {
        if (itemIndex >= 0 && itemIndex < items.Length)
        {
            Item item = items[itemIndex].GetComponent<Item>();
            if (item != null)
            {
                inventoryManager.EquipItem(item);
            }
        }
    }

    public void UnequipItem(int itemIndex)
    {
        if (itemIndex >= 0 && itemIndex < items.Length)
        {
            Item item = items[itemIndex].GetComponent<Item>();
            if (item != null)
            {
                inventoryManager.UnequipItem(item); 
            }
        }
    }
}
