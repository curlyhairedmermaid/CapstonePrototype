using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Goes to the overview level
/// </summary>
public class ToOverview : MonoBehaviour {

	/// <summary>
	/// Gos to overview.
	/// </summary>
	public void GoToOverview () {
		SceneManager.LoadScene ("OVerviewLevel", LoadSceneMode.Single);
	}
}