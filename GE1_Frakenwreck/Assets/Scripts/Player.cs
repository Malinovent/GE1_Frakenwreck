using UnityEngine;

public class Player : MonoBehaviour
{
   
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private Animator animator;

    private void Start()
    {
        //animator.SetBool("isBankingLeft", false);
        //animator.Play("BANK LEFT");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ShootBullet();
    }

    private void ShootBullet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBulletProjectile();
        }
    }

    public void ShootBulletProjectile()
    {
        //Create a clone of bullet
        //Instantiate(bullet, transform.position + new Vector3(0, 0.5f), Quaternion.identity);
        Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
    }

    private void Movement()
    {
        //UP
        if(Input.GetKey(KeyCode.W))        
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);

        //DOWN
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);


        //LEFT
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            animator.Play("BANK LEFT");
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.Play("IDLE");
        }

            //RIGHT
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            animator.Play("BANK RIGHT");
        }
    }
}
