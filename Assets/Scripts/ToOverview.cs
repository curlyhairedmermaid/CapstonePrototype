using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToOverview : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void GoToLevel1 () {
		SceneManager.LoadScene ("OVerviewLevel", LoadSceneMode.Single);
	}
}