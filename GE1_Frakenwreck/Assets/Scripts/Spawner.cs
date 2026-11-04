using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToSpawn;
    [SerializeField] private float spawnWidth = 8;
    [SerializeField] private float spawnMinInterval = 2;
    [SerializeField] private float spawnMaxInterval = 5;

    private float timeThatPassed = 0;
    private float interval = 0;

    private void Start()
    {
        SetInterval();
    }

    private void Update()
    {
        timeThatPassed += Time.deltaTime;

        if(timeThatPassed >= interval)
        {
            SpawnObject();
            timeThatPassed = 0;
            SetInterval();
        }
    }

    private void SetInterval()
    {
        interval = Random.Range(spawnMinInterval, spawnMaxInterval);
    }

    private void SpawnObject()
    {
        //Pick a random object in the list
        int randomIndex = Random.Range(0, objectsToSpawn.Length);

        //Pick a random X position across the top of the screen
        float randomX = Random.Range(-spawnWidth / 2, spawnWidth / 2);
        Vector3 spawnPosition = transform.position + new Vector3(randomX, 0, 0);

        Instantiate(objectsToSpawn[randomIndex], spawnPosition, Quaternion.identity);
    }
    

    //Other methods to complete to our class
    public void StartSpawning()
    {

    }

    public void StopSpawning()
    {

    }

}
