using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coinPrefabs; 
    public int maxCoins; 
    public float spawnInterval;
    public Vector2 spawnAreaMin; 
    public Vector2 spawnAreaMax;

    private List<GameObject> activeCoins = new List<GameObject>();

    void Start()
    {
        StartCoroutine(SpawnCoinsRoutine());
    }

    IEnumerator SpawnCoinsRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            if (activeCoins.Count < maxCoins)
            {
                SpawnCoin();
            }
        }
    }

    void SpawnCoin()
    {
        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        GameObject coinPrefab = coinPrefabs[Random.Range(0, coinPrefabs.Length)];
        GameObject newCoin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        activeCoins.Add(newCoin);
    }

    public void RemoveCoin(GameObject coin)
    {
        activeCoins.Remove(coin);
        Destroy(coin);
    }
}
