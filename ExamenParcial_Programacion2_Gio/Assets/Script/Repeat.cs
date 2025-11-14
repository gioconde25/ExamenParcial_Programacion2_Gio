using UnityEngine;

public class Repeat : MonoBehaviour
{
    private float spriteWidth;

    void Start()
    {
        BoxCollider2D bgCollider = GetComponent<BoxCollider2D>();
        spriteWidth = bgCollider.size.x;
    }

    void Update()
    {
        if (transform.position.x < -spriteWidth)
        {
            transform.Translate(Vector2.right * 2f * spriteWidth);
        }
    }
}
