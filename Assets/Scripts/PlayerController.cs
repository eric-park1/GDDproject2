using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;
    public Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1) {
            movement = Input.GetAxisRaw("Vertical");
        } 
        else 
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, movement * speed);
    }

    public void Reset() 
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPosition;
    }
}
