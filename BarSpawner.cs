using UnityEngine;

public class BarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject barAndJungleSpawn;
    [SerializeField] private float initialSpawnRate = 2f;
    private float spawnRate;
    private float timer = 0f;
    private float heightOffset = 2f;

    public int playerScore = 0;
    [SerializeField] private int scoreThreshold = 10;
    [SerializeField] private float spawnRateMultiplier = 0.9f;

    void Start()
    {
        if (barAndJungleSpawn == null)
        {
            Debug.LogError("barAndJungleSpawn is not assigned!");
            return;
        }
        spawnRate = initialSpawnRate;
        SpawnObstacle();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (playerScore >= scoreThreshold)
        {
            spawnRate *= spawnRateMultiplier;
            playerScore = 0;
        }

        if (timer >= spawnRate)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        if (barAndJungleSpawn == null) return;

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);

        Instantiate(barAndJungleSpawn, spawnPosition, Quaternion.identity);
    }

    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }
}
