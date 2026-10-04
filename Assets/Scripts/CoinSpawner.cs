using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnInterval = 1.2f;
    public float minX = -3f;
    public float maxX = 3f;
    public float spawnY = 6f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnCoin();
            timer = 0f;
        }
    }

    void SpawnCoin()
    {
        if (coinPrefab == null)
            return;

        Vector3 position = new Vector3(Random.Range(minX, maxX), spawnY, 0f);
        Instantiate(coinPrefab, position, Quaternion.identity);
    }
}
