using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;
    public Text scoreText; // assign this in Inspector
    public GameObject coinPrefab; // Drag the prefab in Inspector

    public void SpawnCoin()  
    {
        Vector2 spawnPos = new Vector2(Random.Range(-2.5f, 2.5f), Random.Range(4f, 6f));
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        if (scoreText != null)
            scoreText.text = "Score: " + score.ToString();
    }
}
