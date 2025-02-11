using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int RareChance = 10;
    public GameObject CoinPrefab;
    public GameObject RareCoinPrefab;
    public Vector2 MinMaxPos;
    public float SpawnInterval = 0.5f;
    private bool isSpawning = false;
    private float spawnTimer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
            return;
        }

        int currentChange = Random.Range(0, 100);
        if (currentChange > RareChance)
        {

            if (CoinPrefab)
            {
                Vector3 randomSpawnPos = new Vector3(
                    Random.Range(MinMaxPos.x, MinMaxPos.y),
                    transform.position.y,
                    transform.position.z);
                GameObject.Instantiate(CoinPrefab, randomSpawnPos, Quaternion.identity);
            }
        }

        else
        {
            if (RareCoinPrefab)
            {
                Vector3 randomSpawnPos = new Vector3(
                    Random.Range(MinMaxPos.x, MinMaxPos.y),
                    transform.position.y,
                    transform.position.z);
                GameObject.Instantiate(RareCoinPrefab, randomSpawnPos, Quaternion.identity);
            }
        }
        
        
        // reset timer
        spawnTimer = SpawnInterval;

    }
}
