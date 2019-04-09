using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongCollisionJudge : MonoBehaviour {
	public GameObject interactObject;
	[HideInInspector]
	public static bool isStrongCollision = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision interactObject)
	{
		if (interactObject.relativeVelocity.magnitude > 2)
			isStrongCollision = true;
	}
}   
