using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddCoins(coinValue);
            CoinSpawner coinSpawner = FindObjectOfType<CoinSpawner>();
            coinSpawner.RemoveCoin(gameObject);
        }
    }
}
