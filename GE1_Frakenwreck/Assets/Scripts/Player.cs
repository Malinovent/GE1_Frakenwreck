using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        bool wIsPressed = Input.GetKey(KeyCode.W);

        if(wIsPressed)
        {
            transform.position += new Vector3(0,speed,0);
        }
    }
}
