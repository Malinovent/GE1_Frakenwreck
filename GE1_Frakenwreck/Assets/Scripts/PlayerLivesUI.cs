using UnityEngine;

public class PlayerLivesUI : MonoBehaviour
{
    [SerializeField] private int maxLives = 5;
    [SerializeField] private int startingLives = 3;
    [SerializeField] private GameObject[] lifeIcons;
    private int currentLives = 0;

    private void Start()
    {
        currentLives = startingLives;
        UpdateUI();
    }

    //TESTING ONLU
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            LoseLife();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GainLife();
        }
    }

    public void LoseLife()
    {         
        currentLives--;
        if (currentLives <= 0)
        {
            GameOver();
        }

        UpdateUI();
    }

    public void GainLife()
    {
        currentLives++;
        if(currentLives > maxLives)
        {
            currentLives = maxLives;
        }

        UpdateUI();
    }

    private void UpdateUI()
    {
        //Active life icons based on currentLives
        for(int i = 0; i < lifeIcons.Length; i++)
        {
            lifeIcons[i].SetActive(i < currentLives);
        }

    }

    private void GameOver()
    {

    }
}
