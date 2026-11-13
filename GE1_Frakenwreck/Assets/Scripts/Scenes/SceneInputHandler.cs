using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInputHandler : MonoBehaviour
{
       
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
