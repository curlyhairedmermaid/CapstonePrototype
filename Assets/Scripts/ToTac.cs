using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Switches scenes to Tac
/// </summary>
public class ToTac : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Destroy(GameObject.Find("MovetoTac"));
                if(hit.transform.position.x <= 16.5)
                {
                    if(hit.transform.)
                }
            }
        }
    }
}

