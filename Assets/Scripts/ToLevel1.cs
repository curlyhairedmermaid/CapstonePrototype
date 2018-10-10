using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// Switches scenes to Tac
/// </summary>
public class ToLevel1 : MonoBehaviour
{
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{			
				if(hit.collider.gameObject.tag == "Load1")
				{
					SceneManager.LoadScene("Level1", LoadSceneMode.Single);
				}

			}

		}
	}
}

