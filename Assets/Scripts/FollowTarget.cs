using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour {
    /// <summary>
    /// The target we're following
    /// </summary>
    public Transform target;
    /// <summary>
    /// the amount the camera eases to the player as the player moves away
    /// </summary>
    public float easeMultiplier = 10;

    public float offsetMinY = 1;
    public float offsetMaxY = 5;

    OrbitalCamera orbit;
    void Start ()
    {
        orbit = GetComponent<OrbitalCamera>();
    }
	void FixedUpdate () {
        Vector3 offset = new Vector3(0, Mathf.Lerp(offsetMinY, offsetMaxY, orbit.pitchPercent));
       transform.position = Vector3.Lerp(transform.position, target.position+offset, Time.fixedDeltaTime * easeMultiplier);
	}
}
