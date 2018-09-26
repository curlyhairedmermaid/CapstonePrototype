using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highligh : MonoBehaviour
{
    Material ToHighlight;
    bool hovering; 


    // Use this for initialization
    void Start()
    {
        ToHighlight = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (hovering==true)
        {
            ToHighlight.color = Color.yellow;
        }
        else
        {
            
            ToHighlight.color = Color.red;
        }
        hovering = false;


    }
    private void OnMouseOver()
    {
        hovering = true;
    }
}
