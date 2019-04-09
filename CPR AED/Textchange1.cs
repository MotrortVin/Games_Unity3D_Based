using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textchange : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Text Text1;
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick() {
        {
            GameObject.Find("Text1").GetComponent<Text>().text = GameObject.Find("Button1/Text").GetComponent<Text>().text.ToString();
        } }	
	// Update is called once per frame
	void Update () {
		
	}
}
