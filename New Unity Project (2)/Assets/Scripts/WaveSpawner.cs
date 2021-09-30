using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Waypoints[] waypointsArray;
    public Transform spawnLocation;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    public TextAlignment waveCountDown;

    private int waveIndex = 0;

    private void Start()
    {
        waypointsArray = Object.FindObjectsOfType<Waypoints>();
        spawnLocation = waypointsArray[0].transform;        
    }

    private void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        // waveCountdownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;

        for (int i = 0; i < waypointsArray.Length; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnLocation.position, spawnLocation.rotation);
    }
}
