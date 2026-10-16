using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
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
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
    

    //Other methods to complete to our class
    public void StartSpawning()
    {

    }

    public void StopSpawning()
    {

    }

}
