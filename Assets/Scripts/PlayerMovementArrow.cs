using UnityEngine;
using System.Collections;

public class PlayerMovementArrow : MonoBehaviour
{

    float moveSpeed = 2f;            // Player's speed when walking.
    float rotationSpeed = 6f;
    float jumpHeight = 10f;         // How high Player jumps
    Vector3 EulerAngleVelocity;


    Vector3 moveDirection;

    Rigidbody rb;

    // Using the Awake function to set the references
    void Awake()

    {
        
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Move();

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
        print(transform.rotation);
    }

    void Move()
    {
       
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(-hAxis, 0f, -vAxis);
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
        rb.rotation = Quaternion.LookRotation(-movement);
        rb.position += movement* moveSpeed * Time.deltaTime;

        if (hAxis > 0)
        {
            TurnLeft();
        } else if (hAxis < 0)
        {
            TurnRight();
        }
    }
    void TurnLeft()
    {
        EulerAngleVelocity = new Vector3(0, 100, 0);
        Quaternion deltaRotation = Quaternion.Euler(EulerAngleVelocity * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);

    }
    void TurnRight()
    {
        EulerAngleVelocity = new Vector3(0, -100, 0);
        Quaternion deltaRotation = Quaternion.Euler(EulerAngleVelocity * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);

    }
}