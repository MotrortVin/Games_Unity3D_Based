using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Control : MonoBehaviour {
	public bool ifDailed = false;
	// Use this for initialization
	void Start () {
		
	}
	public IEnumerator WaitForDailing()
	{
		// Keep coming back each frame whilst the groups are currently fading.
		while (!ifDailed)
		{
			yield return null;
		}
	}
	// Update is called once per frame
	void Update () {
        Text Text1;
        Text Text2;
        Text Text3;
        Text Text4;

        if (GameObject.Find("Text1").GetComponent<Text>().text == "1")
             if (GameObject.Find("Text2").GetComponent<Text>().text == "2")
                if(GameObject.Find("Text3").GetComponent<Text>().text == "3")
                     {
                    GameObject.Find("Text4").GetComponent<Text>().text = "拨号成功";
                    GameObject.Find("Text2").GetComponent<Text>().text = " ";
                    GameObject.Find("Text3").GetComponent<Text>().text = " ";
                    GameObject.Find("Text1").GetComponent<Text>().text = " ";
			ifDailed = true;
        }

    }
}
