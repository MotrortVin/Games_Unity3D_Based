using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckPerson : MonoBehaviour {
	public MaterialChanger checkNeck;
	public MaterialChanger checkNose;
	public MaterialChanger checkRightShoulder;
	public MaterialChanger checkLeftShoulder;
	public bool ifCheckPerson = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ifCheckPerson = checkNeck.ifTouched && checkNose.ifTouched && (checkRightShoulder.ifTouched || checkLeftShoulder.ifTouched);
	}
	public IEnumerator WaitForCheckingPerson()
	{
		// Keep coming back each frame whilst the groups are currently fading.
		while (ifCheckPerson == false)
		{
			yield return null;
		}
	}
}
