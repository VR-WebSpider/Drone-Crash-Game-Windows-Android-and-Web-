using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed = 2f;
    private float spriteWidth;

    private void Start()
    {
        spriteWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -spriteWidth)
        {
            Reposition();
        }
    }

    private void Reposition()
    {
        transform.position += new Vector3(spriteWidth * 2f, 0f, 0f);
    }
}
