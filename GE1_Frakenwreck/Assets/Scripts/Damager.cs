using UnityEngine;

//Deals damage to the health component
public class Damager : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log($"Triggered with {other.gameObject.name}");

        /*if (other.gameObject.CompareTag("Enemy"))
        {
            //this.GetComponent<Health>();
            other.GetComponent<Health>().TakeDamage(damageAmount);           
        }*/

        Health health = other.GetComponent<Health>();

        if(health != null)
        {
            health.TakeDamage(damageAmount);
        }

        Dispose();
        //Other = the other object we triggered with

    }

    private void Dispose()
    {
        Destroy(this.gameObject);
    }













    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Collision with {collision.gameObject.name}");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
}
