using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Switches scenes to Tac
/// </summary>
public class ToTac : MonoBehaviour
{
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
                SceneManager.LoadScene("Tac", LoadSceneMode.Single);
            }
        }
    }
}

