using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using Color = UnityEngine.Color;

public class Granica : MonoBehaviour
{
    public Material Change;
    public Color start;
    public Color end;
    public bool IsNear;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "collider")
        {
            IsNear = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "collider")
        {
            IsNear = false;
        }
    }
    private void FixedUpdate()
    {
        if (IsNear)
        {
            Change.color = Color.Lerp(Change.color, end, 4 * Time.deltaTime);
        }
        if (!IsNear)
        { 
            Change.color = Color.Lerp(Change.color, start,  4 * Time.deltaTime);
        }
    }
}

