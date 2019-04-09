using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShoulderText : MonoBehaviour {
	public GameObject ShowText;
	public int duarationTime;
	// Use this for initialization
	void Start () {
		GameObject.Find ("Canvas/Text").GetComponent<Text> ().text = "他已经失去了意识";
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision interactObject)
	{
		ShowText.SetActive (true);
		Invoke ("TextVanish", duarationTime);

	}

	void TextVanish()
	{
		ShowText.SetActive (false);
	}
}
