//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using HoloToolkit.Unity.InputModule;

public class GazeTriggerTest : MonoBehaviour , IFocusable
{
    public Material origin;
    public Material highlight;
    /*public UnityEvent FocusEnterEvent = new UnityEvent();
    public UnityEvent FocusExitEvent = new UnityEvent();
    public UnityAction FocusEnter;
    public UnityAction FocusExit;*/
    // Use this for initialization
    void Start () {
        //FocusEnterEvent.AddListener(FocusEnter);
        //FocusExitEvent.AddListener(FocusExit);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnFocusEnter()
    {
        GetComponent<Renderer>().material.color = highlight.color;//object change color to highlight 
        //if (FocusEnter != null) FocusEnterEvent.Invoke();
        //if (FocusEnter != null)
        //{
        //     FocusEnter();
        //}
    }

    public void OnFocusExit()
    {
        //if (FocusExit != null) FocusExitEvent.Invoke();
        GetComponent<Renderer>().material.color = origin.color;//object change color to highlight 
        //if (FocusExit != null)
        //{
        //    FocusExit();
        //}
    }

}
