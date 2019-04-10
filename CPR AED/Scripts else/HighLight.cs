using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLight : MonoBehaviour {
    public GameObject ball;
    public Material highlight;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider interactObject)
    {
        ball.GetComponent<Renderer>().material.color = highlight.color;//object change color to highlight 

        //ifTouched = true;
    }
}
