using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    public int coins = 100;
    public GameObject storePanelUI;
    public GameObject customizationPanelUI;
    public GameObject MenuPanelUI;
    public GameObject ControlPanelUI;


    private bool isPaused = false;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        MenuPanelUI.SetActive(true);
        Debug.Log("Monedas: " + coins);
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        Debug.Log("Monedas: " + coins);
    }
    void Update()
    {
        if (storePanelUI.activeSelf || customizationPanelUI.activeSelf || MenuPanelUI.activeSelf ||ControlPanelUI.activeSelf )
        {
            if (!isPaused) 
            {
                Pause();
                Debug.Log("JuegoPausado");

            }
        }
        else
        {
            if (isPaused) 
            {
                Resume();
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f; 
        isPaused = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f; 
        isPaused = true;
    }

}
