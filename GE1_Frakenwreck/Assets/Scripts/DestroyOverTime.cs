using UnityEngine;

public class DestroyOverTime : MonoBehaviour
{

    [SerializeField] private float timeToDestroyInSeconds = 5f;

    private float timePassed = 0;

    // Update is called once per frame
    void Update()
    {

        timePassed += Time.deltaTime;

        if (timePassed >= timeToDestroyInSeconds)
        {
           Dispose();
        }
    }

    //Destroy wrapper
    private void Dispose()
    {
        Destroy(this.gameObject);
    }
}
