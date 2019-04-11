using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColorChanger : MonoBehaviour {
    public GazeTriggerTest gazeControl;
    public Material origin;
    public Material highlight;
    // Use this for initialization
    void Start () {
        //gazeControl.FocusEnter += HighlightColor;
        //gazeControl.FocusExit += originalColor;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void HighlightColor ()
    {
        GetComponent<Renderer>().material.color = highlight.color;//object change color to highlight 
    }

    void originalColor ()
    {
        GetComponent<Renderer>().material.color = origin.color;//object change color to highlight 
    }
}
