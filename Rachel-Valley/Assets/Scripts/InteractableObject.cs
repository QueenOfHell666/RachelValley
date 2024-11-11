using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string objectName; 
    public GameObject paneldialogue;
    public GameObject panelSP;

    void Start()
    {
        paneldialogue.SetActive(false);
        Debug.Log("Panel desactivado al inicio");
    }

    public void Interact()
    {
        paneldialogue.SetActive(false);
        panelSP.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entró en el trigger con el jugador");
            paneldialogue.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Entró en el trigger con el jugador");
            paneldialogue.SetActive(false);
        }
    }
}
