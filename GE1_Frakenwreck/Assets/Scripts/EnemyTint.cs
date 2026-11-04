using UnityEngine;

//Changes the color of the enemy sprite
//Lets us make new variants without new art
public class EnemyTint : MonoBehaviour
{
    [SerializeField] private Color tint = Color.white;

    private void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = tint;
    }
}
