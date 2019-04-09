using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppear: MonoBehaviour {
	public GameObject ShowText;
	public int duarationTime;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}




	void OnCollisionEnter(Collision interactObject)
	{
		GameObject.Find ("Canvas/Text").GetComponent<Text>().text = "他已经没有了呼吸";
		ShowText.SetActive (true);
		Invoke ("TextVanish", duarationTime);

	}

	void TextVanish()
	{
		ShowText.SetActive (false);
	}
}
