using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    /// <summary>
    /// The transform to the target
    /// </summary>
    public Transform viewTarget;
    private bool lookAt = true;
    // Use this for initialization
    void Start()
    {
    }
    /// <summary>
    /// Late update is called after update
    /// </summary>
    // Update is called once per frame
    void LateUpdate()
    {


        if (viewTarget)
        {
            //easing
            transform.position += new Vector3((viewTarget.position.x - (transform.position.x)) * .1f, (viewTarget.position.y - (transform.position.y - 6)) * .1f, (viewTarget.position.z - (transform.position.z - 5)) * .1f);
        }
    }
}

