using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Follows a target.
/// </summary>
public class FollowTarget : MonoBehaviour {
    /// <summary>
    /// The target we're following
    /// </summary>
    public Transform target;
    /// <summary>
    /// the amount the camera eases to the player as the player moves away
    /// </summary>
    public float easeMultiplier = 10;
	/// <summary>
	/// The offset minimum y.
	/// </summary>
    public float offsetMinY = 1;
	/// <summary>
	/// The offset max y.
	/// </summary>
    public float offsetMaxY = 5;
	/// <summary>
	/// Reference to the orbital camera
	/// </summary>
    OrbitalCamera orbit;
	/// <summary>
	/// Start this instance.
	/// </summary>
    void Start ()
    {
        orbit = GetComponent<OrbitalCamera>();
    }
	/// <summary>
	/// Updates and offsets the position
	/// </summary>
	void FixedUpdate () {
        Vector3 offset = new Vector3(0, Mathf.Lerp(offsetMinY, offsetMaxY, orbit.pitchPercent));
       transform.position = Vector3.Lerp(transform.position, target.position+offset, Time.fixedDeltaTime * easeMultiplier);
	}
}
