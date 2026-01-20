using UnityEngine;

public class MiniPlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);

        if (dir.magnitude > 1f)
            dir.Normalize();

        transform.position += (Vector3)dir * speed * Time.deltaTime;
    }
}
