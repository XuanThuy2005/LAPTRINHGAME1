using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 45f; // thấp hẳn xuống
    public bool smooth = true;

    void Update()
    {
        if (!target) return;

        Vector2 dir = target.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        Quaternion lookRot = Quaternion.Euler(0, 0, angle);

        if (smooth)
        {
            // XOAY MƯỢT: chậm, có độ trễ
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                lookRot,
                rotateSpeed * Time.deltaTime
            );
        }
        else
        {
            // SNAP: quay NGAY LẬP TỨC
            transform.rotation = lookRot;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            smooth = !smooth;
            Debug.Log("Smooth mode: " + smooth);
        }
    }
}
