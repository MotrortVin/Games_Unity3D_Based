//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using HoloToolkit.Unity.InputModule;
using VRStandardAssets.Utils;

public class GazeTracker : MonoBehaviour, IFocusable
{
    public UnityAction FocusEnter;
    public UnityAction FocusExit;
    public bool ifGazed = false;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnFocusEnter()
    {
        if(FocusEnter != null) FocusEnter();
        gameObject.GetComponent<SelectionSlider>().m_GazeOver = true;
    }

    public void OnFocusExit()
    {
        if (FocusExit != null) FocusExit();
        gameObject.GetComponent<SelectionSlider>().m_GazeOver = false;
    }
}