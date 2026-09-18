using UnityEngine;

public class Player : MonoBehaviour
{
   
    [SerializeField] private float speed = 0.1f;

    //Serialized class field
    [SerializeField] private Transform transformComponent;


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
            //Inherited
            //transform.position += new Vector3(0,speed,0);

            //Find the transform
            //Transform transform = GetComponent<Transform>();
            //transform.position += new Vector3(0, speed, 0);

            //GetComponent<Transform>().position += new Vector3(0, speed, 0);

            //Serialized Exampled
            transformComponent.position += new Vector3(0, speed, 0);
        }
    }
}
