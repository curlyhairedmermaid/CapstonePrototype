﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// This code makes the object in question highlight yellow when moused over
/// </summary>
public class HighlightonRollover : MonoBehaviour
{
    /// <summary>
    /// The material highlight
    /// </summary>
    Material toHighlight;
    /// <summary>
    /// if the item is being overed over or not
    /// </summary>
    bool hovering; 


    // Use this for initialization
    void Start()
    {
        toHighlight = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (hovering==true)
        {
            toHighlight.color = Color.yellow;
        }
        else
        {
            
            toHighlight.color = Color.red;
        }
        hovering = false;


    }
    /// <summary>
    /// if the mouse is over or not
    /// </summary>
    private void OnMouseOver()
    {
        hovering = true;
    }
}
