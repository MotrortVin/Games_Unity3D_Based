using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Onclearenter4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

}
    void OnCollisionEnter(Collision interactobject)
    {
        Text Text2;
        GameObject.Find("Text2").GetComponent<Text>().text = GameObject.Find("Button2/Text").GetComponent<Text>().text.ToString();
    }
}
