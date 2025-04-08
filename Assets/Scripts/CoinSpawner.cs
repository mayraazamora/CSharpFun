using UnityEngine;
using System.Collections.Generic;

public class CoinSpawner : MonoBehaviour
{
    public float minX = -2.5f;
    public float maxX = 2.5f;
    public float minY = 4f;
    public float maxY = 6f;


    public GameObject coinPrefab;
    public int maxCoins = 3;
    public float spawnInterval = 2f;

    private List<GameObject> activeCoins = new List<GameObject>();

    void Start()
    {
        InvokeRepeating(nameof(SpawnCoin), 1f, spawnInterval);
    }

    void SpawnCoin()
    {
        // Only spawn if we haven't hit the max
        activeCoins.RemoveAll(c => c == null); // Clean up destroyed coins

        if (activeCoins.Count < maxCoins)
        {
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
            GameObject coin = Instantiate(coinPrefab, spawnPos, Quaternion.identity);
            activeCoins.Add(coin);
        }
    }
}