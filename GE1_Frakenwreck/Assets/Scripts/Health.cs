using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;

    private int currentHealth;

    private void Start()
    {
        FullHeal();
    }

    public void FullHeal()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if(currentHealth <= 0)
        {
            Dispose();
        }
    }

    private void Dispose()
    {
        Destroy(this.gameObject);
    }
}
