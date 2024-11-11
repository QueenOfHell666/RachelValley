using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public int itemIndex;
    public TextMeshProUGUI buttonText;
    private ShopManager shopManager;
    void Start()
    {
        shopManager = FindObjectOfType<ShopManager>();
        UpdateButtonUI();
    }
    public void OnButtonClicked()
    {
        shopManager.PurchaseItem(itemIndex);
    }

    void UpdateButtonUI()
    {
        Item item = shopManager.items[itemIndex].GetComponent<Item>();
        if (item != null && buttonText != null)
        {
            buttonText.text = $"{item.itemName} - {item.price} Coins";
        }
    }
}
