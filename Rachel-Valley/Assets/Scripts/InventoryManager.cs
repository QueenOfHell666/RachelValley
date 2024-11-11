using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class InventoryManager : MonoBehaviour
{
    public List<Item> purchasedItems = new List<Item>();
    private UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public void EquipItem(Item item)
    {
        if (item.isPurchased && !item.isEquipped)
        {
            item.EquipItem();
            Debug.Log(item.itemName + " ha sido equipado.");
        }
        else if (item.isEquipped)
        {
            Debug.Log(item.itemName + " ya está equipado.");
        }
        else
        {
            Debug.Log("No has comprado " + item.itemName);
        }
    }

    public void UnequipItem(Item item)
    {
        if (item.isEquipped)
        {
            item.UnequipItem();
            Debug.Log(item.itemName + " ha sido desequipado.");
        }
        else
        {
            Debug.Log(item.itemName + " no está equipado.");
        }
    }
}
