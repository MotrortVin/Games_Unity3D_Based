using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;


public class Lefthand: MonoBehaviour {
    public Transform leftHand;
    public Transform rightHand;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        leftHand.localPosition = InputTracking.GetLocalPosition(XRNode.LeftHand);
        rightHand.localPosition = InputTracking.GetLocalPosition(XRNode.RightHand);
        Text Text0;
        GameObject.Find("Text0").GetComponent<Text>().text = leftHand.localPosition.y.ToString();
    }
}
