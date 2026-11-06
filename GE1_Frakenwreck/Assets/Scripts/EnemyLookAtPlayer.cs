using UnityEngine;

//Turns the Visual child so the enemy always faces the player
public class EnemyLookAtPlayer : MonoBehaviour
{
    [SerializeField] private Transform visual;

    private Transform player;

    private void Start()
    {
        //Find the player with its tag
        GameObject playerObject = GameObject.FindWithTag("Player");

        gameObject.SetActive(true);

        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            return;
        
        //Direction from the enemy to the player
        Vector3 direction = player.position - visual.position;

        //Angle of that direction, in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //The enemy sprite points down, so we add 90 degrees
        visual.rotation = Quaternion.Euler(0, 0, angle + 90);
        
    }
}
