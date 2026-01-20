using UnityEngine;

public class MiniTurretRotation : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 60f;

    void Update()
    {
        if (!target) return;

        Vector2 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        Quaternion lookRot = Quaternion.Euler(0, 0, angle);

        transform.rotation = Quaternion.RotateTowards(
            transform.rotation,
            lookRot,
            rotateSpeed * Time.deltaTime
        );
    }
}
