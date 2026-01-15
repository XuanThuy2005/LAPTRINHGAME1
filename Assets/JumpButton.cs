using UnityEngine;

public class JumpButton : MonoBehaviour
{
    public float jumpForce = 6f;

    private Rigidbody rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // HÀM GỌI TỪ BUTTON
    public void Jump()
    {
        if (isGrounded)
        {
            Debug.Log("JUMP button pressed on Android");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
