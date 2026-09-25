using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, speed, 0);
    }
}
