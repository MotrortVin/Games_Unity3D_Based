using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour {
    public bool ifEnabled = false;
    public bool ifPressed = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider interactObject)
    {
        if(ifEnabled) ifPressed = true;
    }
}
