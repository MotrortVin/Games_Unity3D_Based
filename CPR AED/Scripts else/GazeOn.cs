using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using HoloToolkit.Unity.InputModule;

public class GazeOn : MonoBehaviour, IFocusable
{
    public bool ifGazed = false;
    //public UnityEvent FocusEnterEvent;
    //public UnityEvent FocusLostEvent;
    // Use this for initialization


    public void OnFocusEnter()
    {
        ifGazed = true;
    }

    public void OnFocusExit()
    {
        ifGazed = false;
    }
}
