using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public int price;
    public bool isPurchased = false;
    public bool isEquipped = false;
    public GameObject itemVisual; 

    void Start()
    {
        if (itemVisual != null)
        {
            itemVisual.SetActive(isEquipped);
        }
    }

    public void PurchaseItem()
    {
        if (!isPurchased && GameManager.Instance.coins >= price)
        {
            GameManager.Instance.coins -= price;
            isPurchased = true;
            Debug.Log(itemName + " comprado con éxito");
        }
        else if (isPurchased)
        {
            Debug.Log(itemName + " ya ha sido comprado.");
        }
        else
        {
            Debug.Log("No tienes suficientes monedas para comprar " + itemName);
        }
    }

    public void EquipItem()
    {
        if (isPurchased && !isEquipped)
        {
            isEquipped = true;
            if (itemVisual != null)
            {
                itemVisual.SetActive(true);
            }
            Debug.Log(itemName + " equipado.");
        }
    }

    public void UnequipItem()
    {
        if (isPurchased && isEquipped)
        {
            isEquipped = false;
            if (itemVisual != null)
            {
                itemVisual.SetActive(false);
            }
            Debug.Log(itemName + " desequipado.");
        }
    }
}
