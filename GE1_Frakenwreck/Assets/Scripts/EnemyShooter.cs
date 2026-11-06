using UnityEngine;

//Shoots a bullet every few seconds
public class EnemyShooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireInterval = 2f;

    private float timePassed = 0;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed >= fireInterval)
        {
            timePassed = 0;
            Shoot();
        }
    }

    private void Shoot()
    {
        //Create a clone of the bullet at the fire point
        Instantiate(bullet, firePoint.position, Quaternion.identity);
    }
}
