using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;
    [SerializeField] private int pointsOnDeath = 1;

    [SerializeField] private UnityEvent onDamageTaken;
    [SerializeField] private UnityEvent onDeath;

    private int currentHealth;

    private void Start()
    {
        FullHeal();        
        //scoreTracker = GameObject.Find("Score Container").GetComponent<ScoreTracker>();
        //scoreTracker = FindObjectOfType<ScoreTracker>();
        //scoreTracker = GameObject.FindGameObjectWithTag("ScoreTracker").GetComponent<ScoreTracker>();
    }

    public void FullHeal()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        onDamageTaken.Invoke();

        if (currentHealth <= 0)
        {
            Dispose();
            onDeath.Invoke();
        }
    }

    private void Dispose()
    {
        Destroy(this.gameObject);
        AddPoints();
    }

    //Adds points to the UI
    private void AddPoints()
    {
        //SOLID
        //S = Single Responsibility Principle
        //scoreTracker.AddPoints(pointsOnDeath);
        ScoreTracker.Singleton.AddPoints(pointsOnDeath);
    }
}
