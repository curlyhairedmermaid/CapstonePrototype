using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    /// <summary>
    /// The agent being called
    /// </summary>
    UnityEngine.AI.NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
    }

    /// <summary>
    /// updates every frame. on mouse down, shoots a ray out to see where the mouse is pointed and moves the character there
    /// </summary>
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(hitInfo.point);
            }
        }
    }
}
