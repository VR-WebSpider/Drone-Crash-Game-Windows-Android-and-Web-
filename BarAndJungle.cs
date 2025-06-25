using UnityEngine;

public class BarAndJungle : MonoBehaviour
{
    public float barSpeed;
    public float deadJone = -15;

    void Update()
    {
        transform.position = transform.position + (Vector3.left * barSpeed) * Time.deltaTime;

        if (transform.position.x < deadJone)
        {
            Destroy(gameObject);
        }
    }
}
