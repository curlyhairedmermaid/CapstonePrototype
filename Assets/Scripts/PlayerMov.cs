using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class PlayerMov : MonoBehaviour {

    public float rotSpeed;
    public float playerSpeed;
    //var targetRotation2;

    void Update()
    {
        
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        if (hAxis > 0)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * rotSpeed);
        }
        else if (hAxis < 0)
        {
            transform.Rotate(-Vector3.up, Time.deltaTime * rotSpeed);
        }
        if (vAxis > 0)
        {
           // var lookPos = target.position - transform.position;
           // lookPos.y = 0;
           // var rotation = Quaternion.LookRotation(lookPos);
           // rotation *= Quaternion.Euler(0, 90, 0);
            transform.position += transform.rotation * Vector3.forward * Time.deltaTime;
        }
    }
}*/

public class PlayerMov : MonoBehaviour
{

    public float moveSpeed;

    public float rotationSpeed;
    private Vector3 previousLocation;

    private Vector3 moveDirection;

         void Update()
        {
            float moveVertical = Input.GetAxis("Vertical");
            float moveHorizontal = Input.GetAxis("Horizontal");

            Vector3 newPosition = new Vector3(moveHorizontal, 0.0f, moveVertical);
            transform.LookAt(newPosition - new Vector3(1, 0, 1) + transform.position );
            transform.Translate(newPosition * moveSpeed * Time.deltaTime, Space.World);
        }
    }