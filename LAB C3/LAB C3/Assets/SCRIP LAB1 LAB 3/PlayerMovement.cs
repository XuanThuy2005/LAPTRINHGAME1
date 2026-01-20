using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 moveDir;

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // A / D
        float v = Input.GetAxis("Vertical");   // W / S

        moveDir = new Vector3(h, v, 0);

        // Nếu vector dài hơn 1 → normalize
        if (moveDir.magnitude > 1f)
        {
            moveDir.Normalize();
        }

        transform.position += moveDir * speed * Time.deltaTime;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position,
                        transform.position + moveDir);
    }
}
