using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMousOver : MonoBehaviour {

    private Color startColor;
    private Color mouseOverColor;
    bool mouseOver = false;
    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.GetColor("_Color");
        mouseOverColor = new Color32(0,200,0,0);
    }

    void OnMouseOver()
    {
        Debug.Log("Mouse is over GameObject.");
        mouseOver = true;
        rend.material.SetColor("_Color", mouseOverColor);
       
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse is no longer on GameObject.");
        mouseOver = false;
        rend.GetComponent<Renderer>().material.SetColor("_Color", startColor);
    }
}
