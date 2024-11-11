using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject panelshop;
    public GameObject panelPer;
    public GameObject panelMenu;
    public GameObject panelControl;

    public void OpenControls()
    {
        panelControl.SetActive(true);
    }

    public void ExitShop()
    {
        panelshop.SetActive(false);
    }

    public void ExitSkins()
    {
        panelPer.SetActive(false);
    }

    public void ExitMenu()
    {
        panelMenu.SetActive(false);
        Debug.Log("QuitarPanelMenu");
    }

    public void ExitControl()
    {
        panelControl.SetActive(false);
        Debug.Log("QuitarPanelMenu");
    }

    public void ExitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }


}
