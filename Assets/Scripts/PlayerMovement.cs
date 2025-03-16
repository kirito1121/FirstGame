using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // T?c ?? di chuy?n

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // L?y Rigidbody2D c?a nh�n v?t
    }

    void Update()
    {
        // L?y input t? b�n ph�m (A, D, W, S ho?c ph�m m?i t�n)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Di chuy?n nh�n v?t theo h??ng input
        rb.linearVelocity = movement.normalized * moveSpeed;
    }
}
