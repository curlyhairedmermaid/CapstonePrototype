using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// logic for an orbital camera
/// </summary>
public class OrbitalCamera : MonoBehaviour {
    /// <summary>
    /// pitch = y
    /// </summary>
    float pitch = 0;
    /// <summary>
    /// yaw = x
    /// </summary>
    float yaw = 0;
    /// <summary>
    /// the min amount on the y axis
    /// </summary>
    public float pitchMin = 0;
    /// <summary>
    /// the max amount on the y axis 
    /// </summary>
    public float pitchMax = 80;
    /// <summary>
    /// the min amount on the x axis can be seen
    /// </summary>
    public float yawMin = -80;
    /// <summary>
    /// the farthest amount on the x axis can be seen
    /// </summary>
    public float yawMax = 80;
    /// <summary>
    /// the sensitivity of y movment
    /// </summary>
    public float pitchSensitivity = 1;
    /// <summary>
    /// the sensitivy of x movment
    /// </summary>
    public float yawSensitivity = 5;
    /// <summary>
    /// is the pitch inverted
    /// </summary>
    public bool pitchInvert = true;
    /// <summary>
    /// is the yaw inverted
    /// </summary>
    public bool yawInvert = false;
    /// <summary>
    /// The target local position value for the child camera object
    /// </summary>
    private Vector3 dollyPosition;
    /// <summary>
    /// the amount the camera eases to the player as the player moves away
    /// </summary>
    float dollyEaseMultiplier = 10;
    /// <summary>
    /// the farthest the dolly get get from the player
    /// </summary>
    public float dollyMaxDistance = 20;
    /// <summary>
    /// The closest the dolly can get to the player
    /// </summary>
    public float dollyMinDistance = 10;
    /// <summary>
    /// Creates a percentage from the pitch amount
    /// </summary>
    public float pitchPercent
    {
        get
        {
            return (pitch - pitchMin) / (pitchMax - pitchMin);
        }
    }
    /// <summary>
    /// setting the location of the dolly
    /// </summary>
    void Start () {
       // dollyPosition = cam.localPosition;
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
        LookAround();

        Zoom();
    }
    /// <summary>
    /// Enables the player to zoom in and out
    /// </summary>
    private void Zoom()
    {
        dollyPosition += new Vector3(0, 0, Input.mouseScrollDelta.y);

        dollyPosition.z = Mathf.Clamp(dollyPosition.z, -dollyMaxDistance, -dollyMinDistance);


        cam.localPosition = Vector3.Lerp(cam.localPosition, dollyPosition, Time.deltaTime * dollyEaseMultiplier);
    }
    /// <summary>
    /// enables the player to look around
    /// </summary>
    private void LookAround()
    {
        float lookX = Input.GetAxis("Mouse X");
        float lookY = Input.GetAxis("Mouse Y");

        pitch += lookY * pitchSensitivity * (pitchInvert ? -1 : 1);
        yaw += lookX * yawSensitivity * (yawInvert ? -1 : 1);

        pitch = Mathf.Clamp(pitch, pitchMin, pitchMax);

        transform.eulerAngles = new Vector3(pitch, yaw, 0);
    }
    /// <summary>
    /// in the editor draws where the camera is looking
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, Vector3.one);
    }
}
