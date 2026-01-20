using UnityEngine;

public class SignedAngleRotator : MonoBehaviour
{
    public float currentAngle;

    void Update()
    {
        // Lấy vị trí chuột trong world
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        Vector2 dir = mousePos - transform.position;

        // Hướng gốc của nhân vật (2D topdown)
        Vector2 forward = transform.right;

        // Tính góc signed
        currentAngle = Vector2.SignedAngle(forward, dir);

        // Xoay nhân vật
        transform.Rotate(0, 0, currentAngle * Time.deltaTime);
    }
}
