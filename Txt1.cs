using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Txt1 : MonoBehaviour
{

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision interactobject)
    {
        Text Text3;
        GameObject.Find("Text3").GetComponent<Text>().text = GameObject.Find("Button0/Text").GetComponent<Text>().text.ToString();
    }
}
