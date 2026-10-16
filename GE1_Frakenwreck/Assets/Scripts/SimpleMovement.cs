using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveDirection.x * speed * Time.deltaTime, moveDirection.y * speed * Time.deltaTime, 0);
    }
}
