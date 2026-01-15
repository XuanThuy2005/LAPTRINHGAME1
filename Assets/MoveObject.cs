using UnityEngine;
using PinePie.SimpleJoystick;

public class MoveObject : MonoBehaviour
{
    
    public float speed = 8f;
    public float jumpForce = 6f;
public JoystickController joystick;



    private Rigidbody rb;
    private bool isGrounded;

    // ===== DÙNG CHO ANDROID BUTTON =====
    private float btnMoveX = 0f;
    private float btnMoveZ = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
{
    float moveH = Input.GetAxis("Horizontal");
    float moveV = Input.GetAxis("Vertical");

    if (joystick != null)
    {
        Vector2 dir = joystick.InputDirection;

        // Chỉ override khi joystick đang được kéo
        if (dir.magnitude > 0.01f)
        {
            moveH = dir.x;
            moveV = dir.y;
        }
    }

    Vector3 movement = new Vector3(moveH, 0f, moveV) * speed;
    rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
}

    void Update()
    {
        // ===== PC JUMP =====
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    // ===== ANDROID + PC DÙNG CHUNG =====
    public void Jump()
    {
        if (isGrounded)
        {
            Debug.Log("JUMP pressed");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // ===== BUTTON MOVE =====
    public void MoveLeft()  { btnMoveX = -1f; }
    public void MoveRight() { btnMoveX =  1f; }
    public void MoveUp()    { btnMoveZ =  1f; }
    public void MoveDown()  { btnMoveZ = -1f; }

    public void StopX() { btnMoveX = 0f; }
    public void StopZ() { btnMoveZ = 0f; }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }
}
