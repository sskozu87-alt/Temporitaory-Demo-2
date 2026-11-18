using UnityEditor.Callbacks;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private float moveDir = 0;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) moveDir = -1; //left
        if (Input.GetKey(KeyCode.D)) moveDir = 1; //right

        if(
            (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) || //pressing none
            (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) //pressing both
        ) moveDir = 0;

    
       rb.linearVelocity = new Vector2(moveDir*moveSpeed, rb.linearVelocity.y);
    }
}
