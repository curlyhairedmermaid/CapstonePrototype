using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Switches player to level 1
/// </summary>
public class ToLevel1 : MonoBehaviour
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
                SceneManager.LoadScene("Level1", LoadSceneMode.Single);
            }
        }
    }
}
