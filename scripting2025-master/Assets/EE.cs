using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMatrix : MonoBehaviour
{
    public GameObject coinPrefab; // Prefab de la moneda
    public float spacing = 1.0f; // Espaciado entre monedas

    private readonly int[,] runPattern = new int[,]
    {
        // R          U           N
        {0, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 1, 0, 0, 1},
        {0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 1},
        {0, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1},
        {0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1},
        {0, 0, 0, 1, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1}
    };

    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        int rows = runPattern.GetLength(0);
        int cols = runPattern.GetLength(1);
        float startX = -(cols - 1) * spacing / 2f;
        float startY = (rows - 1) * spacing / 2f;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (runPattern[row, col] == 1)
                {
                    Vector3 position = transform.position + new Vector3(startX + col * spacing, startY - row * spacing, 0);
                    GameObject coin = Instantiate(coinPrefab, position, Quaternion.identity, transform);
                    coin.name = $"Coin_{row}_{col}";
                }
            }
        }
    }
}
