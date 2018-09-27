using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// The movement logic for our character
/// </summary>
public class PlayerMovement : MonoBehaviour {
    /// <summary>
    /// The agent being called
    /// </summary>
    NavMeshAgent agent;
    // Use this for initialization
    void Start () {
    }
	
	/// <summary>
    /// updates every frame. on mouse down, shoots a ray out to see where the mouse is pointed and moves the character there
    /// </summary>
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                GetComponent<NavMeshAgent>().SetDestination(hitInfo.point);
            }
        }
    }


}
