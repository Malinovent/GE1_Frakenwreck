using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour
{

    private int currentScore = 0;
    [SerializeField] private TMP_Text scoreText;

    public static ScoreTracker Singleton;

    //Happens before start
    //Always happens even on inactive gameObject
    private void Awake()
    {
        if (Singleton == null)
        {
            Singleton = this;
        }
        else
        {
            Destroy(this);
        }

        //Debug.Log("Awake!");
    }

    #region order of execution
    private void OnEnable()
    {
        //Debug.Log("Activated!");
    }

    private void OnDisable()
    {
        //Debug.Log("Dectivated!");
    }

    //Happens after first activation
    private void Start()
    {
        //Debug.Log("Start!");
    }

    /*private void OnDestroy()
    {
        Debug.Log("Destroyed!");
    }*/


    #endregion

    public void AddPoints(int points)
    {
        currentScore += points;
        //scoreText.text = currentScore.ToString();
        scoreText.SetText(currentScore.ToString());

        Debug.Log("Current Score: " + currentScore);
    }
}
